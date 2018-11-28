using System;
using System.Collections.Generic;

namespace Kalendergenerator
{
    class YearPrinter
    {        
        /// <summary>
        /// Gibt jeden Monat im angegebenen Jahr auf der Konsole aus.
        /// </summary>
        /// <param name="year">Auszugebendes Jahr.</param>
        public void PrintYear(Year year)
        {
            // Jahreszahlausgabe
            Console.WriteLine(year.YearNumber);
            // Monatsausgabe
            foreach (var item in year.MonthList)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
    }
}
