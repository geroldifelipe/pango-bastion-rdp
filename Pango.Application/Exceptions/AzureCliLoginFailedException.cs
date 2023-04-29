using System.Runtime.Serialization;

namespace Pango.Application.Exceptions
{
    [Serializable]
    public class AzureCliLoginFailedException : Exception
    {
        public AzureCliLoginFailedException()
        {
        }

        public AzureCliLoginFailedException(string? message) : base(message)
        {
        }

        public AzureCliLoginFailedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AzureCliLoginFailedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}