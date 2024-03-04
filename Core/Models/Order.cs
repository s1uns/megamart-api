using Core.Enums;
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
        public Guid CustomerId { get; set; }
        public ICollection<OrderPosition> OrderPositions { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.JustCreated;
    }
}