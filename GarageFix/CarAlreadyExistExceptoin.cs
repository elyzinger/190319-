using System;
using System.Runtime.Serialization;

namespace GarageFix
{
    [Serializable]
    public class CarAlreadyExistExceptoin : ApplicationException
    {
        public CarAlreadyExistExceptoin()
        {
        }

        public CarAlreadyExistExceptoin(string message) : base(message)
        {
        }

        public CarAlreadyExistExceptoin(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CarAlreadyExistExceptoin(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}