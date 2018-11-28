using System;
using System.Runtime.Serialization;

namespace PMC_Klausur_17A_1
{
    [Serializable]
    internal class MissingArgsElement : Exception
    {
        public MissingArgsElement()
        {
        }

        public MissingArgsElement(string message) : base(message)
        {
        }

        public MissingArgsElement(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MissingArgsElement(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}