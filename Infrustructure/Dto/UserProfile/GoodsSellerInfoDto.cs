using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Dto.UserProfile
{
    public record GoodsSellerInfoDto
    (
        string SellerId,
        string SellerPicUrl,
        string SellerName
    );
}
