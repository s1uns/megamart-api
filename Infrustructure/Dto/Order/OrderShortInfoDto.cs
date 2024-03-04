using Core.Enums;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Dto.Order
{
    public record OrderShortInfoDto
    (
        Guid CustomerId,
        decimal Total,
        DateTime CreatedAt,
        OrderStatus OrderStatus
    );
}
