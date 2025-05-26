using System;
namespace Convocatoria2
{
    /* Ex.7 */
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceNumber = "Introdueix un número enter positiu: ";
            const string MsgInputError = "Error. Introdueix un enter positiu.";

            int inputNumber = 0;
            string result = "";

            // Demanar número i validar
            Console.WriteLine(MsgIntroduceNumber);
            while (!int.TryParse(Console.ReadLine(), out inputNumber) || inputNumber <= 0)
            {
                Console.WriteLine("\n" + MsgInputError);
            }
            Console.WriteLine();

            // Trobar divisors parells
            for (int i = 1; i <= inputNumber; i++)
            {
                if (inputNumber % i == 0) // Comprovar si 'i' és divisor de 'inputNumber'
                {
                    if (i % 2 == 0) // Si el divisor 'i' és parell
                    {
                        result += i + " ";
                    }
                }
            }

            // Si té divisors parells, mostrar resultat
            if (result.Length > 0)
            {
                Console.WriteLine($"Els divisors parells de {inputNumber} són: {result}.");
            }
            else // Si no en té, informar 
            {
                Console.WriteLine($"El numero {inputNumber} no té divisors parells.");
            }
        }
    }
}
    