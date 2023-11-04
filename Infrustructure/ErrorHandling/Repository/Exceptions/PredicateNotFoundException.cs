﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.ErrorHandling.Repository.Exceptions
{
    public class PredicateNotFoundException : Exception
    {
        public PredicateNotFoundException() { }
        public PredicateNotFoundException(string message) : base(message) { }
        public PredicateNotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}