using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = "No description";
        public string Color { get; set; } = "FFFFFF";
        public string LogoUrl { get; set; } = string.Empty;
    }
}