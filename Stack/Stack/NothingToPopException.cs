using System;
using System.Runtime.Serialization;

namespace Stack
{
    [Serializable]
    public class NothingToPopException : Exception
    {
        public NothingToPopException()
        {
        }

        public NothingToPopException(string message) : base(message)
        {
        }

        public NothingToPopException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NothingToPopException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}