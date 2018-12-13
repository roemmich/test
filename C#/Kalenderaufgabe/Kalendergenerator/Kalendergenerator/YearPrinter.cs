using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendergenerator
{
    class YearPrinter
    {
        //private List<Month> monthList;
        
        public void PrintYear(List<Month> monthList)
        {   
            Console.WriteLine();
            foreach (var item in monthList)
            {
                Console.WriteLine(item);
            }            
            // Ausgabe fehlt noch.
        }

        public void PrintYear(Year year)
        {
            Console.WriteLine(year.YearNumber);
            //Console.WriteLine(year.MonthList[0].Year);
            Console.WriteLine();
            foreach (var item in year.MonthList)
            {
                Console.WriteLine(item);
            }
            // Ausgabe fehlt noch.
        }

        public void Print()
        {
            Console.WriteLine("");
        }
    }
}
