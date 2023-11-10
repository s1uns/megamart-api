using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Good : BaseEntity
    {
        public Seller Seller { get; set; }
        public Guid SellerId { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<Category>? Categories { get; set; }
        public GoodCreationStatus CreationStatus { get; set; } = GoodCreationStatus.JustCreated;
        public GoodAvailabilityStatus AvailabilityStatus { get; set; }
    }
}