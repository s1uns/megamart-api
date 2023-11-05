using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.ErrorHandling.Services.Category
{
    public class CategoryDeleteException : Exception
    {
        public CategoryDeleteException() { }
        public CategoryDeleteException(string message) : base(message) { }
        public CategoryDeleteException(string message, Exception inner) : base(message, inner) { }
    }
}