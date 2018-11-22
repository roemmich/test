using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendergenerator
{
    class Month
    {
        private int number;
        private int year;
        private List<Week> weekQueue;
        private readonly string[] week = { "SONNTAG", "MONTAG", "DIENSTAG", "MITTWOCH", "DONNERSTAG", "FREITAG", "SAMSTAG" };
        public int Number
        {
            get { return Number; }
            set { Number = value; }
        }
        public int Year
        {
            get { return Year; }
            set { Year = value; }
        }
        public List<Week> WeekQueue
        {
            get { return WeekQueue; }
            set { WeekQueue = value; }
        }
        public string[] Week
        {
            get { return Week; }
        }

        /// <summary>
        /// Konstruktor der Klasse Month.
        /// </summary>
        /// <param name="number">Monatsnummer (1-12)</param>
        /// <param name="year">Jahr des Monats</param>
        public Month(int number, int year)
        {
            this.number = number;
            this.year = year;
            this.weekQueue = new List<Week>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\t").Append(new DateTime(year, number, 1).ToString("MMMM"));
            sb.Append("\n  S  M  T  W  T  F  S");
            sb.Append("\n_______________________\n");
            return sb.ToString();
        }
    }
}
