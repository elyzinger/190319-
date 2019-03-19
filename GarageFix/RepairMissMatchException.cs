using System;
using System.Runtime.Serialization;

namespace GarageFix
{
    [Serializable]
    internal class RepairMissMatchException : Exception
    {
        public RepairMissMatchException()
        {
        }

        public RepairMissMatchException(string message) : base(message)
        {
        }

        public RepairMissMatchException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepairMissMatchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}