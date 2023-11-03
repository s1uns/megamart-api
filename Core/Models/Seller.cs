using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Seller : BaseEntity
    {        
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Site { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
        public List<Good> Goods { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}