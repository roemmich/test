using System;

namespace Kalendergenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            YearPrinter printer = new YearPrinter();
            string firstArgument = "";
            string secondArgument = "";
            try
            {
                firstArgument = args[0];
                secondArgument = args[1];
            }
            catch (System.IndexOutOfRangeException)
            { }
            CommandLineParser clParser = new CommandLineParser(firstArgument, secondArgument);
            // Konsolenausgabe des Jahres.
            printer.PrintYear(new Year(clParser.Year, clParser.WeekStartday));
        }
    }
}
