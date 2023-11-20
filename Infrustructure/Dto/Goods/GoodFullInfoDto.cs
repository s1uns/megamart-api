using Core.Enums;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Dto.Goods
{ //TODO: change enums and goodoptions with created Dtos
    public record GoodFullInfoDto(
        Guid Id, 
        string Name, 
        string Description,
        decimal Price, 
        string ImgUrl, 
        List<GoodOption> GoodOptions, 
        GoodCreationStatus GoodCreationStatus,
        GoodAvailabilityStatus GoodAvailabilityStatus,
        string SellerName
    );
}