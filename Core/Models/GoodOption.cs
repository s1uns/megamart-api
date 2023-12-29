using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class GoodOption : BaseEntity
    {
        public Good Good { get; set; }
        public Guid GoodId { get; set; }
        public string OptionName { get; set; }
    }
}