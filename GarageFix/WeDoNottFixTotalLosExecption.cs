using System;
using System.Runtime.Serialization;

namespace GarageFix
{
    [Serializable]
    internal class WeDoNottFixTotalLosExecption : Exception
    {
        public WeDoNottFixTotalLosExecption()
        {
        }

        public WeDoNottFixTotalLosExecption(string message) : base(message)
        {
        }

        public WeDoNottFixTotalLosExecption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WeDoNottFixTotalLosExecption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}