using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Seller : User
    {        
        public string Name { get; set; } = string.Empty;
        public string WebsiteUrl { get; set; } = string.Empty;
        public ICollection<Good> Goods { get; set; }
        public bool IsVerified { get; set; }
    }
}