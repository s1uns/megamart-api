using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.ErrorHandling.Services.Category
{
    public class CategoryGetByPredicateException : Exception
    {
        public CategoryGetByPredicateException() { }
        public CategoryGetByPredicateException(string message) : base(message) { }
        public CategoryGetByPredicateException(string message, Exception inner) : base(message, inner) { }
    }
}