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
                StdOutWriter.WriteResult(results);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
