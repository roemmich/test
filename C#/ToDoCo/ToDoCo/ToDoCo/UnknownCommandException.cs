using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoCo
{
    public class UnknownCommandException : Exception
    {
        public string UnknownCommand { get; private set; }
        public UnknownCommandException(string unknownCommand)
        {
            UnknownCommand = unknownCommand;
        }

        public override string ToString()
        {
            return String.Format("Unknown Command: {0}\n{1}", UnknownCommand, base.ToString());
        }
    }
}
