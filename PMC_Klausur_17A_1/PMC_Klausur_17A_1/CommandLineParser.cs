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

        public CommandLineParser(string[] args)
        {
            // TODO: Anzahl und Inhalt Argumente prüfen,
            // TODO: Im Fehlerfall Exception werfen
            // TODO: Werte setzen
            // TODO: Erlaubte Einheiten sind "m", "cm", "km", "inch"
            // TODO: XML-Kommentare ergänzen
            InputUnit = "m";
            OutputUnit = "cm";
            FilePath = "exampledata.txt";
        }

    }
}
