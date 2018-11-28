using System;
using System.Collections.Generic;
using System.IO;

namespace PMC_Klausur_17A_1
{
    public static class FileReader
    {
        /// <summary>
        /// Liest die Datei am angegebenen Pfad aus und gibt eine Liste mit konvertierten und auf größer 0 geprüften double-Werten zurück.
        /// </summary>
        /// <param name="filePath">Pfad zur auszulesenden Datei, die Werte enthält.</param>
        /// <returns></returns>
        public static List<double> GetValues(string filePath)
        {
            // Ergebnisliste
            var result = new List<double>();
            // Die auszulesende Datei wird in einem Stringarray gespeichert.
            string[] stringResult = File.ReadAllLines(filePath);
            // Jeder ausgelesene Wert wird auf Gültigkeit geprüft. 
            // Werte dürfen nicht kleiner als 0 sein und müssen in einen Double-Wert konvertierbar sein.
            foreach (var item in stringResult)
            {
                try
                {
                    // Konvertierung versuchen.
                    double tempResultItem = Convert.ToDouble(item);
                    // Wert kleiner 0 ausschließen
                    if (tempResultItem < 0.0d)
                    {
                        throw new NegativeValueException("Es sind keine negativen Werte erlaubt.");
                    }
                    result.Add(tempResultItem);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Es wurde ein Wert gefunden, der sich nicht konvertieren lässt.");
                }
                catch (NegativeValueException negativeValue)
                {
                    Console.WriteLine(negativeValue.Message);
                }
            }
            return result;
        }
    }
}