using System;
using System.Runtime.Serialization;

namespace Kalendergenerator
{
    [Serializable]
    internal class UnvalidWeekDayException : Exception
    {
        /// <summary>
        /// Tritt auf, wenn ein ungültiger Wochentag angegeben wurde.
        /// </summary>
        public UnvalidWeekDayException()
        {
        }

        public UnvalidWeekDayException(string message) : base(message)
        {
        }

        public UnvalidWeekDayException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnvalidWeekDayException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}