using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Dto.DeliveryMethods
{
    public record EditDeliveryMethodDto(
        Guid Id,
        string Name,
        string? LogoUrl,
        int MinimalPrice
        );
}