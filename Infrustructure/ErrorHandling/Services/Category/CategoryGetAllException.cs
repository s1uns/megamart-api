using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.ErrorHandling.Services.Category
{
    public class CategoryGetAllException : Exception
    {
        public CategoryGetAllException() { }
        public CategoryGetAllException(string message) : base(message) { }
        public CategoryGetAllException(string message, Exception inner) : base(message, inner) { }
    }
}