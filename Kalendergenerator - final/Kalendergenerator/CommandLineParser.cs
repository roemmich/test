using System;
using System.Text;

namespace Kalendergenerator
{
    class CommandLineParser
    {
        public int Year{ get; }
        public StringBuilder ErrorMessage { get; set; }
        public int WeekStartday { get; }


        /// <summary>
        /// Konstruktor der Klasse CommandLineParser. Prüft das eingegebene Jahr auf Gültigkeit (vierstellig, DateTime erzeugbar).
        /// </summary>
        /// <param name="yearInput">Zu konvertierende Jahreszahl. Default: Aktuelles Jahr.</param>
        /// <param name="startDay">Tag, mit dem die Wochenausgabe beginnen soll. 0-6; Sonntag bis Samstag. Default: Sonntag (0).</param>
        public CommandLineParser(string yearInput = "", string startDay = "0")
        {
            ErrorMessage = new StringBuilder();
            // Jahr auf aktuelles Jahr setzen für den default-Wert.
            Year = DateTime.Now.Year;
            try
            {
                int convertedYear = Convert.ToInt32(yearInput);
                // Ist ein Datum nicht erzeugbar, oder hat die eingegebene Jahreszahl nicht die Länge vier, wird eine Exception geworfen.
                if (!DateTime.TryParse("01.01." + yearInput, out DateTime tempDate) || yearInput.Length != 4)
                {
                    throw new UnvalidYearException("");
                }
                // Falls Konvertierung funktioniert hat, wird "Year" überschrieben.
                Year = convertedYear;
            }
            catch (System.FormatException)
            {
                ErrorMessage.Append("Die Eingabezeichenfolge ist keine Zahl! Aktuelles Jahr wird verwendet.");
            }
            catch (UnvalidYearException unvalidYearException)
            {
                ErrorMessage.Append($"{unvalidYearException.Message} Aktuelles Jahr wird verwendet.");
            }
            catch (Exception)
            {
                ErrorMessage.Append("Es ist ein unbekannter Fehler aufgetreten. Aktuelles Jahr wird verwendet.");
            }

            // Startwochentag auf 0 setzen für den default-Wert.
            WeekStartday = 0;
            try
            {
                WeekStartday = Convert.ToInt32(startDay);
                if (WeekStartday < 0 || WeekStartday > 6)
                {
                    throw new UnvalidWeekDayException("Ungültiger Startwochentag angegeben. Es sind nur Tage zwischen 0 (Sonntag) und 6 (Samstag) erlaubt. Sonntag wird verwendet.");
                }
            }
            catch(System.FormatException)
            {
                ErrorMessage.Append("Es wurde kein gültiger Wochenstarttag eingegeben. Sonntag wird verwendet.");
            }
            catch(UnvalidWeekDayException unvalidWeekDay)
            {
                // Wert auf 0 zurücksetzen, falls zu hohe oder niedrige Zahl angegeben wurde.
                WeekStartday = 0;
                ErrorMessage.Append(unvalidWeekDay.Message);
            }
            PrintErrorMessages(ErrorMessage);
        }

        /// <summary>
        /// Printmethode des CommandLineParsers. Wird standardmäßig im Konstruktor aufgerufen.
        /// </summary>
        /// <param name="errors"></param>
        private void PrintErrorMessages(StringBuilder errors)
        {
            // Fehlermedlungen ausgeben
            if (!String.IsNullOrWhiteSpace(ErrorMessage.ToString()))
            {
                Console.WriteLine(ErrorMessage);
            }
        }
    }
}
