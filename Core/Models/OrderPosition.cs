using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class OrderPosition : BaseEntity
    {
        public Good Good { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }
}