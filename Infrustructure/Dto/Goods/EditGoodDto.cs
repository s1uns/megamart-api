using Core.Models;
using Infrustructure.Dto.GoodOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Dto.Goods
{
    public record EditGoodDto(
        Guid Id,
        string Name,
        Guid SellerId, //DELETE LATER
        string Description,
        decimal Price,
        string ImgUrl,
        List<Guid> CategoryIds, 
        List<GoodOptionDto> GoodOptions

    );
}