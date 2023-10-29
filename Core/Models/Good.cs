using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Good : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = "No description";

        public List<Category>? Categories { get; set; }
    }
}