using System;

namespace PMC_Klausur_17A_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var cmdLineParser = new CommandLineParser(args);
                var data = FileReader.GetValues(cmdLineParser.FilePath);
                var results = Converter.ConvertInput(data, cmdLineParser.InputUnit, cmdLineParser.OutputUnit);
                ResultPrinter.Print(results);
            }
            catch(MissingArgsElement ma)
            {
                Console.WriteLine(ma.Message);
            }
            catch (InvalidUnitException iu)
            {
                Console.WriteLine(iu.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Es ist ein Fehler aufgetreten. " + ex.Message);
            }
        }
    }
}
