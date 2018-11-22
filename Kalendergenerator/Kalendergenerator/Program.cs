using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendergenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Die Jahreseingabe erfolgt über das Befehlszeilenargument.
            YearCreator yc = new YearCreator();
            CommandLineParser clp;
            YearPrinter printer = new YearPrinter();
            try
            {
                clp = new CommandLineParser(args[0]);
                if (clp.GotValidYear)
                {
                    //printer.PrintYear(yc.CreateYear(clp.Year).MonthList);
                    printer.PrintYear(yc.CreateYear(clp.Year));

                }
            }
            catch (System.IndexOutOfRangeException ex)
            {
                Console.WriteLine("Es wurde kein Argument angegeben! Es wird das aktuelle Jahr verwendet.");
                //printer.PrintYear(yc.CreateYear().MonthList);
                printer.PrintYear(yc.CreateYear());

            }
        }
    }
}
