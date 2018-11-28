using System;
using System.Runtime.Serialization;

namespace PMC_Klausur_17A_1
{
    /// <summary>
    /// Tritt auf, wenn eine ungültige Einheit angegeben wird.
    /// </summary>
    [Serializable]
    internal class InvalidUnitException : Exception
    {
        public InvalidUnitException()
        {
        }

        public InvalidUnitException(string message) : base(message)
        {
        }

        public InvalidUnitException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidUnitException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}