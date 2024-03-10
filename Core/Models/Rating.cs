using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Rating : BaseEntity
    {
        public Guid GoodId { get; set; }
        public Good Good { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public float Value {get; set; }
    }
}
