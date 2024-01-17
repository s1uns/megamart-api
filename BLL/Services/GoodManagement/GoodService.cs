using AutoMapper;
using BLL.Services.GoodManagement.Interfaces;
using Core.Models;
using DAL.Repository.Interface;
using Infrustructure.Dto.Categories;
using Infrustructure.Dto.GoodOptions;
using Infrustructure.Dto.Goods;
using Infrustructure.Dto.Pagination;
using Infrustructure.ErrorHandling.Services.GenericException;
using Infrustructure.ErrorHandling.Services.GenericExceptions;
using megamart_api.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace BLL.Services.GoodManagement
{
    public class GoodService : IGoodService
    {
        private readonly IRepository<Good> _repository;
        private readonly ILogger<GoodService> _logger;
        private readonly IRepository<GoodOption> _optionsRepository;
        private readonly IMapper _mapper;
        private readonly MegamartContext _context;

        public GoodService(IRepository<Good> repository, ILogger<GoodService> logger, IRepository<GoodOption> optionRepository, IMapper mapper, MegamartContext context)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            _optionsRepository = optionRepository;
            _context = context;
        }

        public async Task<CreateGoodDto> AddGoodAsync(CreateGoodDto goodDto)
        {
            try
            {
                //TODO: for authorized seller add getting his id piece
                var entity = _mapper.Map<Good>(goodDto);
                entity.SellerId = Guid.Parse("11bbe5ad-3ea8-4fd3-b87a-b16c823d250d");
                entity.Rating = 0;
                await _repository.AddAsync(entity);
                entity.Categories = await _context.Categories
                    .Where(c => goodDto.CategoryIds
                    .Contains(c.Id))
                    .ToListAsync();
                return goodDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.AddGoodAsync Good ERROR: {ex.Message}");
                throw new ServiceAddException(ex.Message);
            }
        }

        public async Task<GoodFullInfoDto> AddGoodToCategoryAsync(Guid goodId, Guid categoryId)
        {
            try
            {
               var good = await _context
                    .Goods
                    .Include(g => g.Categories)
                    .FirstOrDefaultAsync(g => g.Id == goodId);

               if (good is null)
               {
                    throw new ServiceEntityIsNullException("Wrong good");
               }

               var category = await _context
                    .Categories
                    .Include(c => c.Goods)
                    .FirstOrDefaultAsync(c => c.Id == categoryId);
               
               if (category is null)
               {
                    throw new ServiceEntityIsNullException("Wrong category");
               }

               good.Categories.Add(category);
               category.Goods.Add(good);
               await _context.SaveChangesAsync();
            
               return _mapper.Map<GoodFullInfoDto>(good);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.AddGoodToCategoryAsync Good ERROR: {ex.Message}");
                throw new ServiceAddException(ex.Message);
            }
        }

        public async Task DeleteGoodAsync(Guid goodId)
        {
            try
            {
                await _repository.DeleteAsync(goodId);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.DeleteGoodAsync Good ERROR: {ex.Message}");
                throw new ServiceDeleteException(ex.Message);
            }
        }

        public async Task<List<GoodShortInfoDto>> GetAllGoodsAsync()
        {
            try
            {
                var goods = _mapper.Map<List<GoodShortInfoDto>>(await _context.Goods
                    .Include(g => g.Categories)
                    .Include(g => g.Seller)
                    .Include(g => g.GoodOptions)
                    .ToListAsync());
                return goods;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetAllGoodsAsync Good ERROR: {ex.Message}");
                throw new ServiceGetAllException(ex.Message);
            }
        }

        public async Task<GoodFullInfoDto> GetGoodByIdAsync(Guid goodId)
        {
            try
            {
                var goodModel = await _context.Goods
                    .Where(g => g.Id == goodId)
                    .Include(g => g.Seller)
                    .Include(g => g.GoodOptions)
                    .FirstOrDefaultAsync();

                if(goodModel is null)
                {
                    throw new ServiceEntityIsNullException("Wrong good");
                }
                var goodDto = _mapper.Map<GoodFullInfoDto>(goodModel);
                return goodDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetGoodByIdAsync Good ERROR: {ex.Message}");
                throw new ServiceGetByIdException(ex.Message);
            }
        }

        public async Task<PageResponseDto<GoodShortInfoDto>> GetGoodsAsync(Guid? categoryId, string sortBy, bool order, string search, int page, int limit)
        {
            try
            {
                var query = _context
                    .Goods
                    .Include(g => g.Categories)
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

                var goods = await query
                    .Skip(page * limit)
                    .Take(limit)
                    .ToListAsync();

                var data = _mapper.Map<List<GoodShortInfoDto>>(goods);
                var totalPages = (query.Count() + limit - 1) / limit;

                return new PageResponseDto<GoodShortInfoDto>
                {
                    Data = data,
                    TotalPages = totalPages
                };
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetGoodByIdAsync Good ERROR: {ex.Message}");
                throw new ServiceGetByIdException(ex.Message);
            }
        }

        public async Task<EditGoodDto> UpdateGoodAsync(EditGoodDto newGoodDto)
        {
            try
            {
                var newGood = await _repository.GetByIdAsync(newGoodDto.Id);
                _mapper.Map<Good>(newGoodDto);
                await _repository.UpdateAsync(newGood);
                return newGoodDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.UpdateGoodAsync Good ERROR: {ex.Message}");
                throw new ServiceUpdateException(ex.Message);
            }
        }
    }
}
