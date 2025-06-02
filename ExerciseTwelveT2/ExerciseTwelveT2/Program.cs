using System;

namespace Convocatoria2
{
    /* 12. Fes un programa que demani un número i digui si és:
    Positiu, negatiu o zero
    Parell o senar
    */
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceNumber = "Introdueix un número enter: ";
            const string MsgInputError = "Error. El número ha de ser un enter.";
            const string MsgNumIsPositive = "És positiu.";
            const string MsgNumIsNegative = "És negatiu.";
            const string MsgNumIsZero = "És zero.";
            const string MsgNumIsEven = "És parell.";
            const string MsgNumIsOdd = "És senar.";

            int inputNumber = 0;

            // Demanar i validar número enter
            Console.WriteLine(MsgIntroduceNumber);
            while (!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.WriteLine();
                Console.WriteLine(MsgInputError);
            }
            Console.WriteLine();

            // Si és positiu
            if (inputNumber > 0)
            {
                Console.WriteLine(MsgNumIsPositive);
            }
            else if (inputNumber < 0) // Si és negatiu
            {
                Console.WriteLine(MsgNumIsNegative);
            }
            else // Si és zerp
            {
                Console.WriteLine(MsgNumIsZero);
            }
            Console.WriteLine();

            // Si és parell
            if (inputNumber % 2 == 0)
            {
                Console.WriteLine(MsgNumIsEven);
            }
            else // Si és senar
            {
                Console.WriteLine(MsgNumIsOdd);
            }
            Console.WriteLine();
        }
    }
}