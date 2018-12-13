using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendergenerator
{
    class CommandLineParser
    {
        private bool gotValidYear;
        public bool GotValidYear
        {
            get { return gotValidYear; }
        }
        private int? year;
        public int Year
        {
            get { return (int)year; }
        }
        private string errorMessage;
        public string ErrorMessage
        {
            get { return errorMessage; }
        }

        // Nullable<int> : Datentyp, der Null sein kann.

        /// <summary>
        /// Konstruktor der Klasse CommandLineParser. Prüft das eingegebene Jahr auf Gültigkeit (vierstellig, DateTime erzeugbar).
        /// </summary>
        /// <param name="yearInput">Erwartet eine Jahreszahl als Input.</param>
        public CommandLineParser(string yearInput)
        {   
            // Im Falle einer Exception, bleibt dieser Wert False.
            gotValidYear = false;
            try
            {
                int tempYear = Convert.ToInt32(yearInput);
                DateTime tempDate;
                // Ist ein Datum nicht erzeugbar, oder hat die eingegebene Jahreszahl nicht die Länge vier, wird eine Exception geworfen.
                if (!DateTime.TryParse("01.01." + yearInput, out tempDate) || yearInput.Length != 4)
                {
                    throw new UnvalidYearException("Ungültiges Jahr eingegeben! Das Jahr muss vierstellig sein.");
                }
                // An dieser Stelle kann von einer fehlerfreien Konvertierung ausgegangen werden. Deshalb erfolgt hier die Initialiserung.
                gotValidYear = true;
                year = tempYear;
                errorMessage = "Keine Fehler. Eingegebenes Jahr wird verwendet.";
                //Console.WriteLine(tempYear);
            }
            catch (System.FormatException)
            {
                errorMessage = "Die Eingabezeichenfolge ist keine Zahl! Aktuelles Jahr wird verwendet.";
                year = DateTime.Now.Year;
                //Console.WriteLine("Die Eingabezeichenfolge ist keine Zahl!");
            }
            catch (UnvalidYearException unvalidYearException)
            {
                errorMessage = $"{unvalidYearException.Message} Aktuelles Jahr wird verwendet.";
                year = DateTime.Now.Year;
                //Console.WriteLine(unvalidYearException.Message);
            }
            catch (Exception)
            {
                errorMessage = "Es ist ein unbekannter Fehler aufgetreten. Aktuelles Jahr wird verwendet.";
                year = DateTime.Now.Year;
                //Console.WriteLine("Es ist ein unbekannter Fehler aufgetreten.");
            }

        }
    }
}
