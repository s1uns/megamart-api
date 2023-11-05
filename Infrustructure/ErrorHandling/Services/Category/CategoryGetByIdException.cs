using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.ErrorHandling.Services.Category
{
    public class CategoryGetByIdException : Exception
    {
        public CategoryGetByIdException() { }
        public CategoryGetByIdException(string message) : base(message) { }
        public CategoryGetByIdException(string message, Exception inner) : base(message, inner) { }
    }
}