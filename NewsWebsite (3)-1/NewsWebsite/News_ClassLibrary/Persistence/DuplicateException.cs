using System;
using System.Runtime.Serialization;

namespace News_ClassLibrary.Persistence
{
    [Serializable]
    internal class DuplicateException : Exception
    {
        public DuplicateException()
        {
        }

        public DuplicateException(string message) : base("Customer or Admin with Information Already Exist")
        {
        }

        public DuplicateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DuplicateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}