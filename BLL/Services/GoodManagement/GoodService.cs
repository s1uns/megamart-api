using AutoMapper;
using BLL.Services.GoodManagement.Interfaces;
using Core.Enums;
using Core.Models;
using Core.Result;
using DAL.Repository.Interface;
using Infrustructure.Dto.Goods;
using Infrustructure.Dto.Pagination;
using Infrustructure.ErrorHandling.Errors.Base;
using Infrustructure.ErrorHandling.Errors.ServiceErrors;
using Infrustructure.ErrorHandling.Services.GenericExceptions;
using Infrustructure.Extensions;
using megamart_api.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace BLL.Services.GoodManagement
{
    public class GoodService : IGoodService
    {
        private readonly IRepository<Good> _repository;
        private readonly ILogger<GoodService> _logger;
        private readonly IRepository<GoodOption> _optionsRepository;
        private readonly IMapper _mapper;
        private readonly MegamartContext _context;
        private readonly IHttpContextAccessor _contextAccessor;

        public GoodService(IRepository<Good> repository, ILogger<GoodService> logger, IRepository<GoodOption> optionRepository, IMapper mapper, MegamartContext context, IHttpContextAccessor contextAccessor)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            _optionsRepository = optionRepository;
            _context = context;
            _contextAccessor = contextAccessor;
        }

        public async Task<Result<GoodFullInfoDto, Error>> AddGoodAsync(CreateGoodDto goodDto)
        {
            try
            {
                var isUserValid = _contextAccessor.TryGetUserId(out Guid userId);

                if (!isUserValid)
                {
                    return UserErrors.InvalidUserId;
                }

                var good = _mapper.Map<Good>(goodDto);
                good.SellerId = userId;
                good.CreationStatus = GoodCreationStatus.Inspecting;
                good.AvailabilityStatus = GoodAvailabilityStatus.Available;
                good.Rating = 0;
                await _context.AddAsync(good);
                good.Categories = await _context.Categories
                    .Where(c => goodDto.CategoryIds
                    .Contains(c.Id))
                    .ToListAsync();

                await _context.SaveChangesAsync();
                return _mapper.Map<GoodFullInfoDto>(good);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.AddGoodAsync Good ERROR: {ex.Message}");
                return GoodServiceErrors.AddGoodError;
            }
        }

        public async Task<Result<bool, Error>> DeleteGoodAsync(Guid goodId)
        {
            try
            {
                var isUserValid = _contextAccessor.TryGetUserId(out Guid userId);

                if (!isUserValid)
                {
                    return UserErrors.InvalidUserId;
                }
                var newGood = await _repository.GetByIdAsync(goodId);

                if (newGood.SellerId != userId)
                {
                    return GoodServiceErrors.WrongSellerError;
                }

                await _repository.DeleteAsync(goodId);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.DeleteGoodAsync Good ERROR: {ex.Message}");
                return GoodServiceErrors.DeleteGoodError;
            }
        }

        public async Task<Result<GoodFullInfoDto, Error>> GetGoodByIdAsync(Guid goodId)
        {
            try
            {
                var goodModel = await _context.Goods
                    .Where(g => g.Id == goodId)
                    .Include(g => g.Seller)
                    .Include(g => g.Categories)
                    .Include(g => g.GoodOptions)
                    .FirstOrDefaultAsync();

                if (goodModel is null)
                {
                    throw new ServiceEntityIsNullException("Wrong good");
                }
                var goodDto = _mapper.Map<GoodFullInfoDto>(goodModel);
                return goodDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetGoodByIdAsync Good ERROR: {ex.Message}");
                return GoodServiceErrors.GetGoodError;
            }
        }

        public async Task<Result<PageResponseDto<GoodShortInfoDto>, Error>> GetGoodsAsync(Guid? categoryId, string sortBy, bool order, string search, int page, int limit)
        {
            try
            {

                var query = _context
                    .Goods
                    .Include(g => g.Categories)
                    .Include(g => g.GoodOptions)
                    .Include(g => g.Seller)
                    .AsQueryable();

                if (search is not null)
                {
                    query = query.Where(g => g.Name.Contains(search));
                }

                if (categoryId is not null)
                {
                    query = query.Where(g => g.Categories.Any(c => c.Id == categoryId));
                }

                switch (sortBy)
                {
                    case "rating":
                        query = order ? query.OrderBy(g => g.Rating) : query.OrderByDescending(g => g.Rating);
                        break;

                    case "price":
                        query = order ? query.OrderBy(g => g.Price) : query.OrderByDescending(g => g.Price);
                        break;

                    case "title":
                        query = order ? query.OrderBy(g => g.Name) : query.OrderByDescending(g => g.Name);
                        break;
                }
                var totalPages = (query.Count() + limit - 1) / limit;

                var c = query.Count();
                if (query.Count() > page * limit)
                {
                    query = query
                        .Skip(page * limit)
                        .Take(limit);
                }

                var data = _mapper.Map<List<GoodShortInfoDto>>(await query.ToListAsync());

                return new PageResponseDto<GoodShortInfoDto>
                {
                    Data = data,
                    TotalPages = totalPages
                };
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetGoodByIdAsync Good ERROR: {ex.Message}");
                return GoodServiceErrors.GetGoodsError;
            }
        }

        public async Task<Result<GoodFullInfoDto, Error>> UpdateGoodAsync(EditGoodDto newGoodDto)
        {
            try
            {
                var isUserValid = _contextAccessor.TryGetUserId(out Guid userId);

                if(!isUserValid)
                {
                    return UserErrors.InvalidUserId;
                }
                var newGood = await _repository.GetByIdAsync(newGoodDto.Id);

                if (newGood.SellerId != userId)
                {
                    return GoodServiceErrors.WrongSellerError;
                }

                _mapper.Map(newGoodDto, newGood);

                await _context.GoodOptions.AsQueryable().Where(oG => oG.GoodId == newGoodDto.Id).ForEachAsync(async (oG) =>
                {
                    if (!newGoodDto.GoodOptions.Select(oG => oG.OptionName).Contains(oG.OptionName))
                    {
                        _context.GoodOptions.Remove(oG);
                    }
                });

                await newGoodDto.GoodOptions.AsQueryable().ForEachAsync(async (oG) =>
                {
                    if (!_context.GoodOptions.Where(oG => oG.GoodId == newGoodDto.Id).Select(oG => oG.OptionName).Contains(oG.OptionName))
                    {
                        await _optionsRepository.AddAsync(new GoodOption { GoodId = newGoodDto.Id, OptionName = oG.OptionName });
                    }
                });

                newGood.Categories = await _context.Categories
                    .Where(c => newGoodDto.CategoryIds
                    .Contains(c.Id))
                    .ToListAsync();
                await _context.SaveChangesAsync();
                return _mapper.Map<GoodFullInfoDto>(newGood);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.UpdateGoodAsync Good ERROR: {ex.Message}");
                return GoodServiceErrors.EditGoodError;
            }
        }

    }
}
