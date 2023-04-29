using System.Runtime.Serialization;

namespace Pango.Application.Exceptions
{
    [Serializable]
    public class AzureCliNotFoundException : Exception
    {
        public AzureCliNotFoundException()
        {
        }

        public AzureCliNotFoundException(string? message) : base(message)
        {
        }

        public AzureCliNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AzureCliNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}