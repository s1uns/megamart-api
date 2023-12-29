using AutoMapper;
using BLL.Services.GoodManagement.Interfaces;
using Core.Models;
using DAL.Repository.Interface;
using Infrustructure.Dto.Categories;
using Infrustructure.Dto.GoodOptions;
using Infrustructure.Dto.Goods;
using Infrustructure.ErrorHandling.Services.GenericException;
using megamart_api.Context;
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

        public async Task<List<GoodFullInfoDto>> GetAllGoodsAsync()
        {
            try
            {
                var categories = _mapper.Map<List<GoodFullInfoDto>>(await _context.Goods
                    .Include(g => g.Seller)
                    .Include(g => g.GoodOptions)
                    .ToListAsync());
                return categories;
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
                    throw new Exception("Wrong good");
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
