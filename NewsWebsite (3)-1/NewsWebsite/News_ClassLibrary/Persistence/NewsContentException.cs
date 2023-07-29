using System;
using System.Runtime.Serialization;

namespace News_ClassLibrary.Persistence
{
    [Serializable]
    internal class NewsContentException : Exception
    {
        public NewsContentException()
        {
        }

        public NewsContentException(string message) : base(message)
        {
        }

        public NewsContentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NewsContentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}