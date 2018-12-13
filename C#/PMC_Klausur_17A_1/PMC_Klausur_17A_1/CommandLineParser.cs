using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC_Klausur_17A_1
{
    class CommandLineParser
    {
        public string[] AllowedUnits = new string[] { "m", "cm", "km", "inch" };

        public string InputUnit { get; private set; }
        public string OutputUnit { get; private set; }
        public string FilePath { get; private set; }

        /// <summary>
        /// Konstruktor. Prüft die Kommandozeilenargumente auf Anzahl und Gültigkeit.
        /// </summary>
        /// <param name="args">Kommandozeilenargumente</param>
        public CommandLineParser(string[] args)
        {
            // Die Anzahl der Kommandozeilenargumente muss drei sein.
            if (args.Length != 3)
            {
                throw new MissingArgsElement("Es wurden nicht alle Argumente angegeben.");
            }
            // Die Einheiten müssen mit den "Allowed-Units" übereinstimmen.
            if (!AllowedUnits.Contains(args[0]) || !AllowedUnits.Contains(args[1]))
            {
                throw new InvalidUnitException("Eingabewerte entsprechen keiner gültigen Einheit.");
            }
            InputUnit = args[0];
            OutputUnit = args[1];
            FilePath = args[2];

        }
    }
}
