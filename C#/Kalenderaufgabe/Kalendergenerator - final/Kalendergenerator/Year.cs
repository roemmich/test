using System;
using System.Collections.Generic;

namespace Kalendergenerator
{
    class Year
    {
        public int YearNumber { get; }
        public List<Month> MonthList { get; }

        /// <summary>
        /// Konstruktor der Klasse Year.
        /// </summary>
        /// <param name="yearNumber">Jahreszahl</param>
        /// <param name="weekStartday">Wochentag, mit dem die Darstellung beginnen soll.</param>
        public Year(int yearNumber, int weekStartday)
        {
            MonthList = new List<Month>();
            // Die MonthList wird aufgefüllt.
            for (int i = 1; i < 13; i++)
            {
                MonthList.Add(new Month(new DateTime(yearNumber, i, 1).Month, yearNumber, weekStartday));
            }
            YearNumber = yearNumber;
        }
    }
}
