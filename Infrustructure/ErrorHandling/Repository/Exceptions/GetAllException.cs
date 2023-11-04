namespace Infrustructure.ErrorHandling.Repository.Exceptions
{
    public class GetAllException : Exception
    {
        public GetAllException() { }
        public GetAllException(string message) : base(message) { }
        public GetAllException(string message, Exception inner) : base(message, inner) { }
    }
}
