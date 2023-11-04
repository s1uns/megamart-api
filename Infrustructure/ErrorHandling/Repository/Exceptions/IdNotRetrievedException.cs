using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.ErrorHandling.Repository.Exceptions
{
    public class IdNotRetrievedException : Exception
    {
        public IdNotRetrievedException() { }
        public IdNotRetrievedException(string message) : base(message) { }
        public IdNotRetrievedException(string message, Exception inner) : base(message, inner) { }
    }
}