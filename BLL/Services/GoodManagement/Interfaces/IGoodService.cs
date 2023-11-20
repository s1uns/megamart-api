using BLL.Services.GenericService.Interfaces;
using Core.Models;
using Infrustructure.Dto.Goods;

namespace BLL.Services.GoodManagement.Interfaces
{
    public interface IGoodService
    {
        public Task<CreateGoodDto> AddAsync(CreateGoodDto goodDto);
        Task<EditGoodDto> UpdateAsync(EditGoodDto newGoodDto);

    }
}