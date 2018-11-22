using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendergenerator
{
    class Year
    {
        private int startDay;
        private List<Month> monthList;
        private int yearNumber;
        // Year bekommt ein zusätzliches Property, damit es im YearPrinter seine Jahreszahl kennt.
        public int YearNumber
        {       
            get { return yearNumber; }
        }
        public List<Month> MonthList
        {
            get { return monthList; }
        }
        public int StartDay
        {
            get { return startDay; }
        }

        /// <summary>
        /// Konstruktor der Klasse Year.
        /// </summary>
        /// <param name="year">Startwochentag des Jahres</param>
        public Year(int year)
        {
            // Der Starttag wird aus dem Datums-Objekt des vorgegebenen year-Parameter berechnet.
            startDay = (int)(new DateTime(year, 1, 1).DayOfWeek);
            monthList = new List<Month>();
            // Die monthQueue wird aufgefüllt.
            for (int i = 1; i < 13; i++)
            {
                monthList.Add(new Month(new DateTime(year, i, 1).Month,year));
            }
            yearNumber = year;
        }
    }
}
