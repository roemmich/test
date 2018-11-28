using System;
using System.Runtime.Serialization;

namespace PMC_Klausur_17A_1
{
    /// <summary>
    /// Tritt auf, wenn ein negativer Wert gefunden wurde.
    /// </summary>
    [Serializable]
    internal class NegativeValueException : Exception
    {
        public NegativeValueException()
        {
        }

        public NegativeValueException(string message) : base(message)
        {
        }

        public NegativeValueException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeValueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}