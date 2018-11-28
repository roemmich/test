using System;

namespace PMC_Klausur_17A_1
{
    /// <summary>
    /// Klasse zur Verwaltung eines Umrechnungsergebnisses
    /// </summary>
    class Result
    {
        /// <summary>
        /// Eingabeeinheit des Wertes
        /// </summary>
        public string InputUnit { get; private set; }

        /// <summary>
        /// Ausgabeeinheit des Wertes
        /// </summary>
        public string OutputUnit { get; private set; }

        /// <summary>
        /// Eingabewert
        /// </summary>
        public double Input { get; private set; }

        /// <summary>
        /// Ausgabewert
        /// </summary>
        public double Output { get; private set; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="inputUnit">Eingabeeinheit des Wertes</param>
        /// <param name="outputUnit">Ausgabeeinheit des Wertes</param>
        /// <param name="inputValue">Eingabewert</param>
        /// <param name="outputValue">Ausgabewert</param>
        public Result(string inputUnit, string outputUnit, double inputValue, double outputValue)
        {
            InputUnit = inputUnit;
            OutputUnit = outputUnit;
            Input = inputValue;
            Output = outputValue;
        }

        public override string ToString()
        {
            return String.Format("{0,-5} {1,-5} => {2,-5} {3,-5}", Input, InputUnit, Output, OutputUnit);
        }
    }
}
