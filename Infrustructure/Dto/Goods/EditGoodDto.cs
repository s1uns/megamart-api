using Core.Enums;
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
        string Description,
        decimal Price,
        string ImgUrl,
        List<Guid> CategoryIds, 
        List<AddGoodOptionDto> GoodOptions,
        GoodAvailabilityStatus AvailabilityStatus
    );
}