using System;
using System.Runtime.Serialization;

namespace Stack
{
    [Serializable]
    public class PushingAfterLimitException : Exception
    {
        public PushingAfterLimitException()
        {
        }

        public PushingAfterLimitException(string message) : base(message)
        {
        }

        public PushingAfterLimitException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PushingAfterLimitException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}