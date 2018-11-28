using System;
using System.Collections.Generic;
using System.Text;

namespace Kalendergenerator
{
    class Month
    {
        // monthNumber ist die zahlenmäßige Darstellung des Monats. Januar = 1, Februar = 2 usw.
        private int monthNumber;
        private int year;
        private List<int> days;
        private int startDay;
        private static char[] weekdays = { 'S', 'M', 'T', 'W', 'T', 'F', 'S' };
        public int MonthNumber { get; }
        public int Year { get; }
        public int StartDay { get; set; }
        public char[] Weekdays { get; set; }


        /// <summary>
        /// Konstruktor der Klasse Month.
        /// </summary>
        /// <param name="monthNumber">Monatsnummer (1-12)</param>
        /// <param name="year">Jahr des Monats</param>
        public Month(int monthNumber, int year, int startDay)
        {
            this.monthNumber = monthNumber;
            this.year = year;
            this.startDay = startDay;
            days = new List<int>();
            // Befüllen der Liste aller Tage eines Monats.
            for (int i = 1; i <= DateTime.DaysInMonth(year, monthNumber); i++)
            {
                days.Add(i);
            }
        }

        /// <summary>
        /// Überschreibung der ToString-Methode, um jeden einzelnen Monat im gewählten Format anzuzeigen.
        /// </summary>
        /// <returns>String des formatierten Monats.</returns>
        public override string ToString()
        {
            // Anzahl Zeichen, die zu Beginn der Kalenderansicht freigehalten werden müssen, um den Tag in der korrekten Spalte anzuzeigen.
            int begin = Convert.ToInt32(new DateTime(year, monthNumber, 1).DayOfWeek);
            // Ist der aktuelle Wochentag kleiner oder gleich dem Startwochentag der Ausgabe, muss neu berechnet werden.
            StringBuilder headerBuilder = new StringBuilder();
            StringBuilder bodyBuilder = new StringBuilder();
            // Monatsnamen darstellen.
            headerBuilder.Append("\t").Append(new DateTime(year, monthNumber, 1).ToString("MMMM")).Append("\n ");
            for (int i = startDay; i < 7;)
            {
                headerBuilder.Append(weekdays[i]).Append("  ");
                i++;
                if (i > 6)
                {
                    i = 0;
                }
                if (i == startDay)
                {
                    break;
                }
            }
            headerBuilder.Append("\n____________________\n");
            // Platzhalterstring einfügen, um den ersten Tag des Monats in der korrekten Spalte anzuzeigen.
            // Begin * 3, weil jeder Tag drei Zeichen einnimmt. Abhängig von der aktuellen Darstellung.
            for (int i = 0; i < (begin * 3); i++)
            {
                bodyBuilder.Append(' ');
            }
            // "lineCounter" speichert die Einfügungen der Tage in einer Wochenzeile. "begin" wird addiert, um die Platzhalter zu ersetzen. 
            int lineCounter = begin;
            // Alle Tage des Monats in richtigem Format hinzufügen.
            foreach (var item in days)
            {
                bodyBuilder.Append(String.Format("{0,2}", item)).Append(' ');
                lineCounter++;
                // Nach sieben Tagen wird eine neue Zeile begonnen.
                if (lineCounter % 7 == 0)
                {
                    bodyBuilder.Append("\n");
                }
            }
            return headerBuilder.Append(bodyBuilder).ToString();
        }
    }
}
