using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace PMC_Klausur_17A_1
{
    /// <summary>
    /// Klasse für Einlesen
    /// </summary>
    public static class FileReader
    {
        /// <summary>
        /// Werte einlesen
        /// </summary>
        /// <param name="filePath">Pfad zur Datei</param>
        /// <returns>Liste mit gültigen Messwerten</returns>
        public static List<double> GetValues(string filePath)
        {
            var fileContent = System.IO.File.ReadAllLines(filePath);
            var result = new List<double>();
            var lineNumber = 0;
            foreach (var entry in fileContent)
            {
                lineNumber++;
                try
                {
                    var value = Convert.ToDouble(entry);
                    if (value >= 0)
                    {
                        result.Add(value);
                    }
                    else {
                        throw new FormatException(String.Format("Wert darf nicht negativ sein: {0}", value));
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Fehler in Zeile {0}: {1}", lineNumber, ex.Message);
                }
            }

            return result;
        }
    }
}