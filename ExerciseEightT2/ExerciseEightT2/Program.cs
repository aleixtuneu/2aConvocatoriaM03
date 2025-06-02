using Microsoft.VisualBasic;
using System;

namespace Convocatoria2
{
    /* 8. Implementa un programa que demani dos nombres per teclat, faci la divisió i capturi possibles excepcions (per ex. divisió entre 0 o format invàlid). */
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceDividend = "Introdueix el dividend: ";
            const string MsgIntroduceDivider = "Introdueix el divisor: ";
            const string MsgResult = "Resultat: {0}";
            const string MsgFormatException = "Error: Format de número invàlid. Has d'introduir valors numèrics.";
            const string MsgDivideByZeroException = "No es pot dividir entre zero.";

            string inputDividend = "";
            string inputDivider = "";
            double dividend = 0;
            double divider = 0;
            double result = 0;

            try
            {
                // Demanar dividend
                Console.WriteLine(MsgIntroduceDividend);
                inputDividend = Console.ReadLine();
                dividend = double.Parse(inputDividend);
                Console.WriteLine();

                // Demanar divisor
                Console.WriteLine(MsgIntroduceDivider);
                inputDivider = Console.ReadLine();
                divider = double.Parse(inputDivider);
                Console.WriteLine();

                // Divisor igual a 0
                if (divider == 0)
                {
                    throw new DivideByZeroException(MsgDivideByZeroException);
                }

                // Resultat
                result = dividend / divider;
                Console.WriteLine(MsgResult, result);
            }
            catch (FormatException)
            {
                Console.WriteLine(MsgFormatException);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
