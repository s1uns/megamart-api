namespace Infrustructure.ErrorHandling.Repository.Exceptions
{
    public class GetByPredicateException : Exception
    {
        public GetByPredicateException() { }
        public GetByPredicateException(string message) : base(message) { }
        public GetByPredicateException(string message, Exception inner) : base(message, inner) { }
    }
}
