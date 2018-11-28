using System;
using System.Collections.Generic;

namespace Kalendergenerator
{
    class Year
    {
        public int YearNumber { get; }
        public List<Month> MonthList { get; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="year">Jahreszahl</param>
        public Year(int year, int weekStartday)
        {
            MonthList = new List<Month>();
            // Die MonthList wird aufgefüllt.
            for (int i = 1; i < 13; i++)
            {
                MonthList.Add(new Month(new DateTime(year, i, 1).Month, year, weekStartday));
            }
            YearNumber = year;
        }
    }
}
