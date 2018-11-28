using System;
using System.Linq;

namespace PMC_Klausur_17A_1
{
    /// <summary>
    /// Klasse zur Verarbeitung der Kommandozeilenparameter
    /// </summary>
    class CommandLineParser
    {
        /// <summary>
        /// Array mit den erlaubten Maßeinheiten
        /// </summary>
        public string[] AllowedUnits = new string[] { "m", "cm", "km", "inch" };

        /// <summary>
        /// Eingabeeinheit
        /// </summary>
        public string InputUnit { get; private set; }

        /// <summary>
        /// Ausgabeeinheit
        /// </summary>
        public string OutputUnit { get; private set; }

        /// <summary>
        /// Pfad zur Eingabedatei
        /// </summary>
        public string FilePath { get; private set; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="args">Array mit den Kommandozeilenparametern</param>
        public CommandLineParser(string[] args)
        {
            if (args.Length != 3)
            {
                throw new InvalidOperationException("Number of arguments does not match. Specify input unit, output unit and file path");
            }

            InputUnit = args[0].Trim();
            OutputUnit = args[1].Trim();
            FilePath = args[2].Trim();

            CheckUnits();
        }

        private void CheckUnits()
        {
            if(!IsValidUnit(InputUnit))
            {
                throw new ArgumentException($"InputUnit {InputUnit} is not valid");
            }

            if (!IsValidUnit(OutputUnit))
            {
                throw new ArgumentException($"OutputUnit {OutputUnit} is not valid");
            }
        }

        private bool IsValidUnit(string value)
        {
            return AllowedUnits.Contains<string>(value);
        }
    }
}
