using System;
using System.Runtime.Serialization;

namespace HomeWork.Services
{
    [Serializable]
    internal class SameBookalreadyAddedExpection : Exception
    {
        public SameBookalreadyAddedExpection()
        {
        }

        public SameBookalreadyAddedExpection(string message) : base(message)
        {
        }

        public SameBookalreadyAddedExpection(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SameBookalreadyAddedExpection(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}