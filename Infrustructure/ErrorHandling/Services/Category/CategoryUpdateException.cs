using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.ErrorHandling.Services.Category
{
    public class CategoryUpdateException : Exception
    {
        public CategoryUpdateException() { }
        public CategoryUpdateException(string message) : base(message) { }
        public CategoryUpdateException(string message, Exception inner) : base(message, inner) { }
    }
}