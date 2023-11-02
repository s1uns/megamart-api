using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Order : BaseEntity
    {
        public Customer Customer { get; set; }
        public Salesman Salesman { get; set; }
        public List<OrderPosition> OrderPositions { get; set; }
        public DeliveryAddress DeliveryAddress { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }
        public decimal Total { get; set; }
        public DateTime DateOfOrder { get; set; } = DateTime.Now;
    }
}