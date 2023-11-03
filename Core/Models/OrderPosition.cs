using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class OrderPosition : BaseEntity
    {
        public Order Order { get; set; }
        public Guid OrderId { get; set; }
        public Good Good { get; set; }
        public Guid GoodId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}