using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Dto.UserProfile
{
    public record UpdateCustomerProfileDto
    (
        string Firstname,
        string LastName,
        string PhoneNumber,
        string ProfilePicUrl
    );
}
