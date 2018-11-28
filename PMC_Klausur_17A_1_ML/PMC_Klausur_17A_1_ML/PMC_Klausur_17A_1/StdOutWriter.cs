using System;
using System.Collections.Generic;

namespace PMC_Klausur_17A_1
{
    /// <summary>
    /// Klasse für die Ausgabe der Ergebnisse
    /// </summary>
    static class StdOutWriter
    {
        /// <summary>
        /// Schreibt den übergebenen Datensatz in die Konsole
        /// </summary>
        /// <param name="resultData">Liste mit Ergebnissen für die Ausgabe</param>
        public static void WriteResult(List<Result> resultData)
        {
            Console.WriteLine(new String('-', 60));
            Console.WriteLine("Umrechnungsergebnisse");
            Console.WriteLine(new String('-', 60));
            foreach (var entry in resultData)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine(new String('-', 60));
        }
    }
}