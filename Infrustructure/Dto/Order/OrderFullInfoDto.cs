using Core.Enums;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Dto.Order
{
    public record OrderFullInfoDto
    (
        Guid CustomerId,
        List<OrderPositionDto> OrderPositions,
        decimal Total,
        DateTime CreatedAt,
        OrderStatus OrderStatus
    );
}
