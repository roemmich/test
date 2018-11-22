using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC_Klausur_17A_1
{
    class Program
    {
        static void Main(string[] args)
        {

            var cmdLineParser = new CommandLineParser(args);
            var data = FileReader.GetValues(cmdLineParser.FilePath);
            var results = Converter.ConvertInput(data, cmdLineParser.InputUnit, cmdLineParser.OutputUnit);

            // TODO:Fehlerbehandlung
            // TODO: Klasse für Ausgabe implementieren und Ausgabe von results hinzufügen
        }
    }
}
