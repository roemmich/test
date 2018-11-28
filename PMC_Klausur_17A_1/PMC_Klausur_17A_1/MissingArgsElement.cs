using System;
using System.Runtime.Serialization;

namespace PMC_Klausur_17A_1
{
    /// <summary>
    /// Titt auf, wenn eine ungültige Anzahl an Argumenten angegeben wird.
    /// </summary>
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