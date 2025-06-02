using System;

namespace Convocatoria2
{
    /* 14. Crea un programa que:
    Demani 5 números i els guardi en un array
    Mostri tots els números introduïts
    Calculi i mostri la suma de tots els números
     */
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceNumber = "Introdueix un número a la posició [{0}]: ";
            const string MsgInputError = "Error, el valor ha de ser un número.";
            const string MsgNumbersResult = "Números introduïts: ";
            const string MsgSumResult = "Suma dels números introduïts: {0}";
            const int Size = 5;

            double[] inputNumbers = new double[Size];
            double inputNumber = 0;
            double sum = 0;

            // Demanar números i validar
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine(MsgIntroduceNumber, i+1);
                if (!double.TryParse(Console.ReadLine(), out inputNumber)) 
                {
                    Console.WriteLine();
                    Console.WriteLine(MsgInputError);
                    i--;
                }
                Console.WriteLine();

                inputNumbers[i] = inputNumber; 
                sum += inputNumber;
            }

            // Mostrar números
            Console.WriteLine(MsgNumbersResult);
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                Console.WriteLine(inputNumbers[i]);
            }
            Console.WriteLine();

            // Mostrar suma
            Console.WriteLine(MsgSumResult, sum);
            Console.WriteLine();
        }
    }
}