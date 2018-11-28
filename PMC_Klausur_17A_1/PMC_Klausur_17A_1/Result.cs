using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC_Klausur_17A_1
{
    class Result
    {
        public string InputUnit { get; }
        public string OutputUnit { get; }
        public double InputValue { get; }
        public double OutputValue { get; }

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="inputUnit">Eingabeeinheit</param>
        /// <param name="outputUnit">Ausgabeeinheit</param>
        /// <param name="inputValue">Eingabewert</param>
        /// <param name="outputValue">Ausgabewert</param>
        public Result(string inputUnit, string outputUnit, double inputValue, double outputValue)
        {
            InputUnit = inputUnit;
            OutputUnit = outputUnit;
            InputValue = inputValue;
            OutputValue = outputValue;
        }
    }
}
