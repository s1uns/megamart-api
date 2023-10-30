using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class DeliveryAddress : BaseEntity
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; } 
        public int HouseNumber { get; set; } = 1;
        public int FlatNumber { get; set; } = 1;
        public int EntryWay { get; set; } = 1;
        public string? PostalCode { get; set; }

    }
}