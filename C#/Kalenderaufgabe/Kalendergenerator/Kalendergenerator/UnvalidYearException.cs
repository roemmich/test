using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendergenerator
{
    public class UnvalidYearException : Exception
    {
        public UnvalidYearException()
        {
        }

        public UnvalidYearException(string message)
            : base("Ungültiges Jahr eingegeben!")
        {
        }

        public UnvalidYearException(string message, Exception inner)
            : base("Ungültiges Jahr eingegeben!", inner)
        {
        }
    }
}
