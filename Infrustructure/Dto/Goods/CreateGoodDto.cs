using Core.Models;

namespace Infrustructure.Dto.Goods
{
    public record CreateGoodDto (
        Guid SellerId, 
        string Name, 
        string Description, 
        decimal Price, 
        string ImgUrl,
        List<Guid> CategoryIds, 
        List<GoodOption> GoodOptions
    );
}