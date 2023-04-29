using System.Runtime.Serialization;

namespace Pango.Application.Exceptions
{
    [Serializable]
    public class AzureCliNotLoggedInException : Exception
    {
        public AzureCliNotLoggedInException()
        {
        }

        public AzureCliNotLoggedInException(string? message) : base(message)
        {
        }

        public AzureCliNotLoggedInException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AzureCliNotLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}