using System;

namespace Convocatoria2
{
    /* 7. Implementa en C# programa que mostri un menú amb opcions:
     a) Calcular àrea d’un rectangle
     b) Mostrar si un any és de traspàs
     c) Sortir del programa
     S’han d’implementar els mètodes estàtics i invocar-los des del programa principal
     */
    public class Program
    {
        public static void Main()
        {
            const string MsgChooseOption = "Selecciona una opció:\na) Calcular àrea d'un rectangle\nb) Mostrar si un any és de traspàs\nc) Sortir del programa";
            const string MsgOptionError = "Selecciona una opció vàlida.";
            const string MsgIntroduceBase = "Introdueix la base: ";
            const string MsgIntroduceHeight = "Introdueix la altura: ";
            const string MsgArea = "Àrea del rectangle: {0}";
            const string MsgNegativeError = "Error, ha de ser un número positiu.";
            const string MsgIntroduceYear = "Introdueix un any: ";
            const string MsgYearError = "Error, introdueix un any vàlid.";
            const string MsgOkYear = "És un any de traspàs.";
            const string MsgKoYear = "No és un any de traspàs.";

            string option = "";
            bool onMenu = true;
            int inputYear = 0;
            double inputBase = 0;
            double inputHeight = 0;

            // Menu
            while (onMenu)
            {
                Console.WriteLine(MsgChooseOption);
                option = Console.ReadLine();
                Console.WriteLine();

                switch(option)
                {
                    // Àrea d'un rectangle
                    case "a":

                        // Validar base
                        Console.WriteLine(MsgIntroduceBase);
                        while (!double.TryParse(Console.ReadLine(), out inputBase) || !IsPositiveNumber(inputBase))
                        {
                            Console.WriteLine(MsgNegativeError);
                            Console.WriteLine();
                        }
                        Console.WriteLine();

                        // Validar altura
                        Console.WriteLine(MsgIntroduceHeight);
                        while (!double.TryParse(Console.ReadLine(), out inputHeight) || !IsPositiveNumber(inputHeight))
                        {
                            Console.WriteLine(MsgNegativeError);
                            Console.WriteLine();
                        }
                        Console.WriteLine();

                        // Calcular Area
                        Console.WriteLine(MsgArea, GetRectangleArea(inputBase, inputHeight));
                        Console.WriteLine();
                        break;
                    
                    // Mostrar si un any es de traspàs
                    case "b":
                        Console.WriteLine(MsgIntroduceYear);
                        while(!int.TryParse(Console.ReadLine(), out inputYear))
                        {
                            Console.WriteLine();
                            Console.WriteLine(MsgYearError);
                        }

                        if (IsLeapYear(inputYear))
                        {
                            Console.WriteLine(MsgOkYear);
                        }
                        else
                        {
                            Console.WriteLine(MsgKoYear);
                        }
                        Console.WriteLine();
                        break;
                    
                    // Sortir del programa
                    case "c":
                        onMenu = false;
                        break;

                    default:
                        Console.WriteLine(MsgOptionError);
                        break;
                }
            }
        }

        // Validar número
        public static bool IsPositiveNumber(double number)
        {
            return number > 0;
        } 

        // Obtenir àrea del rectangle
        public static double GetRectangleArea(double inputBase, double inputHeight)
        {
            return inputBase * inputHeight;
        }

        // Calcular any de traspàs
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
