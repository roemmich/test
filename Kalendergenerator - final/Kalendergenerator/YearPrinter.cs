using System;
using System.Collections.Generic;

namespace Kalendergenerator
{
    class YearPrinter
    {        
        public void PrintYear(Year year)
        {
            Console.WriteLine(year.YearNumber);
            foreach (var item in year.MonthList)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
    }
}
