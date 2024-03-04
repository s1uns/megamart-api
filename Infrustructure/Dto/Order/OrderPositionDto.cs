using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Dto.Order
{
    public record OrderPositionDto(
        Guid GoodId,
        string GoodName,
        int Quantity,
        decimal TotalPrice
    );
}
