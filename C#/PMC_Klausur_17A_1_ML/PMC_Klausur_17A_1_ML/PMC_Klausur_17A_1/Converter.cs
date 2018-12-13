using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PMC_Klausur_17A_1
{
    /// <summary>
    /// Klasse für die Umrechnung der Werte
    /// </summary>
    static class Converter
    {
        /// <summary>
        /// Konvertiert den Eingabewert mit der angegebenen Einheit in die Basiseinheit "Meter"
        /// </summary>
        /// <param name="value">Der Eingabewert</param>
        /// <param name="inputUnit">Die zugehörige Einheit</param>
        /// <returns>Der Eingabewert umgerechnet in Meter</returns>
        private static double ConvertToBaseUnit(double value, string inputUnit)
        {
            var factor = 1.0;
            switch (inputUnit)
            {
                case "m": factor = 1.0; break;
                case "cm": factor = 0.01; break;
                case "km": factor = 1000.0; break;
                case "inch": factor = 0.0254; break;
                default: throw new InvalidOperationException(String.Format("Unknown unit: {0}", inputUnit));
            }

            return value * factor;
        }

        /// <summary>
        /// Konvertiert einen Wert in der Basiseinheit "Meter" in die angegebene Einheit
        /// </summary>
        /// <param name="baseValue">Der Wert in Einheit "Meter"</param>
        /// <param name="outputUnit">Zieleinheit in die umgerechnet werden soll</param>
        /// <returns>Der umgerechnete Wert</returns>
        private static double ConvertToOutputUnit(double baseValue, string outputUnit)
        {
            var factor = 1.0;
            switch (outputUnit)
            {
                case "m": factor = 1.0; break;
                case "cm": factor = 100.0; break;
                case "km": factor = 0.001; break;
                case "inch": factor = 39.3701; break;
                default: throw new InvalidOperationException(String.Format("Unknown unit: {0}", outputUnit));
            }

            return baseValue * factor;
        }

        /// <summary>
        /// Konvertiert den Eingabewert von der Eingabe- in die Ausgabeeinheit
        /// </summary>
        /// <param name="value">Der Wert</param>
        /// <param name="inputUnit">Eingabeeinheit</param>
        /// <param name="outputUnit">Ausgabeeinheit</param>
        /// <returns>Der umgerechnete Wert</returns>
        internal static double ConvertInput(double value, string inputUnit, string outputUnit)
        {
            var baseValue = ConvertToBaseUnit(value, inputUnit);
            return ConvertToOutputUnit(baseValue, outputUnit);
        }

        /// <summary>
        /// Eine Liste von Werten von der Eingabeeinheit in die  Ausgabeeinheit umrechnen
        /// </summary>
        /// <param name="data">Liste mit Werten</param>
        /// <param name="inputUnit">Eingabeeinheit</param>
        /// <param name="outputUnit">Ausgabeeinheit</param>
        /// <returns></returns>
        internal static List<Result> ConvertInput(List<double> data, string inputUnit, string outputUnit)
        {
            var result = new List<Result>();
            foreach (var entry in data)
            {
                result.Add(new Result(inputUnit, outputUnit, entry, ConvertInput(entry, inputUnit, outputUnit)));
            }
            return result;
        }
    }
}