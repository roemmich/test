using System;

namespace Kalendergenerator
{
    public class UnvalidYearException : Exception
    {
        /// <summary>
        /// Tritt auf, wenn ein ungültiges Jahr eingegeben wurde.
        /// </summary>
        public UnvalidYearException()
        {
        }

        public UnvalidYearException(string message)
            : base("Ungültiges Jahr eingegeben! Hinweis: Das Jahr muss vierstellig sein.")
        {
        }

        public UnvalidYearException(string message, Exception inner)
            : base("Ungültiges Jahr eingegeben! Hinweis: Das Jahr muss vierstellig sein.", inner)
        {
        }
    }
}
