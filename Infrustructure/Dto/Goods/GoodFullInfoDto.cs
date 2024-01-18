using Core.Enums;
using Core.Models;
using Infrustructure.Dto.GoodOptions;
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
        List<GoodOptionDto> GoodOptions,
        List<Guid> Categories,
        GoodCreationStatus CreationStatus,
        GoodAvailabilityStatus AvailabilityStatus,
        string SellerName,
        int Rating
    );
}