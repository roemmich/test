using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC_Klausur_17A_1
{
    static class ResultPrinter
    {
        /// <summary>
        /// Gibt die übergebene Liste auf der Konsole aus.
        /// </summary>
        /// <param name="resultList">Liste mit Result-Werten</param>
        public static void Print(List<Result> resultList)
        {
            foreach (var item in resultList)
            {
                Console.WriteLine(item.ToString());
            }
        }      
    }
}
