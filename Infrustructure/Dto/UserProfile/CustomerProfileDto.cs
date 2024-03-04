using Core.Models;
using Infrustructure.Dto.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Dto.UserProfile
{
    public record CustomerProfileDto
    (
        Guid Id,
        string Email,
        string PhoneNumber,
        DateTime CreatedAt,
        string ProfilePicUrl,
        string FullName,
        List<OrderShortInfoDto> Orders
    );
}
