namespace Infrustructure.ErrorHandling.Repository.Exceptions
{
    public class GetByIdException : Exception
    {
        public GetByIdException() { }
        public GetByIdException(string message) : base(message) { }
        public GetByIdException(string message, Exception inner) : base(message, inner) { }
    }
}
