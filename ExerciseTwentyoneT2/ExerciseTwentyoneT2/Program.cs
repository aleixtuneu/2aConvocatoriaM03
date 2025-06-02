using System;
using System.Globalization;

namespace Convocatoria2
{
    /* 21. Crea un programa que:
    Demani una temperatura en graus Celsius
    Pregunti si vol convertir a Fahrenheit o Kelvin
    Mostri el resultat de la conversió
    */
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceTemperature = "Introdueix una temperatura (Cº): ";
            const string MsgSelectOption = "Selecciona una opció:\na) Convertir a graus Fahrenheit (Fº).\nb) Convertir a graus Kelvin (Kº).";
            const string MsgInputError = "Error. El valor ha de ser un número.";
            const string MsgOptionError = "Error. Selecciona una opció vàlida.";
            const string MsgResult = "Temperatura convertida: {0}";

            double celsiusInput = 0;
            string option = "";

            // Demanar i validar temperatura en graus Celsius
            Console.WriteLine(MsgIntroduceTemperature);
            while(!double.TryParse(Console.ReadLine(), out celsiusInput))
            {
                Console.WriteLine();
                Console.WriteLine(MsgInputError);
            }
            Console.WriteLine();

            // Seleccionar opció i validar
            Console.WriteLine(MsgSelectOption);
            option = Console.ReadLine();
            Console.WriteLine();
            switch(option)
            {
                // Convertir Celsius a Fahrenheit
                case "a":
                    Console.WriteLine(MsgResult, ConvertCelsiusToFahrenheit(celsiusInput));
                    break;

                // Convertir Celisus a Kelvin
                case "b":
                    Console.WriteLine(MsgResult, ConvertCelsiusToKelvin(celsiusInput));
                    break;

                default:
                    Console.WriteLine(MsgOptionError);
                    break;
            }
            Console.WriteLine();
        }

        public static double ConvertCelsiusToFahrenheit(double pCelsiusTemperature)
        {
            return (pCelsiusTemperature * 1.8) + 32;
        }

        public static double ConvertCelsiusToKelvin(double pCelsiusTemperature)
        {
            return pCelsiusTemperature + 273.15;
        }
    }
}