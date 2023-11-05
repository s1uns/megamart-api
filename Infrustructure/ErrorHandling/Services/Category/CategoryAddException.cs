using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.ErrorHandling.Services.Category
{
    public class CategoryAddException : Exception
    {
        public CategoryAddException() { }
        public CategoryAddException(string message) : base(message) { }
        public CategoryAddException(string message, Exception inner) : base(message, inner) { }
    }
}