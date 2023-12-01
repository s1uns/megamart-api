using Core.Models;
using Infrustructure.Dto.GoodOptions;

namespace Infrustructure.Dto.Goods
{
    public record CreateGoodDto (
        string Name, 
        string Description, 
        decimal Price, 
        string ImgUrl,
        List<Guid> CategoryIds, 
        List<GoodOptionDto> GoodOptions
    );
}