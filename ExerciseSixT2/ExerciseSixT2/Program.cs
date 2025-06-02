using System;

namespace Convocatoria2
{
    /* 6. Demana 10 números a l’usuari, desa'ls en un array, mostra la mitjana i quants valors són parells i quants no ho són. */
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceNumber = "Introdueix un número a la posició [{0}]: ";
            const string MsgInputError = "Error, el valor ha de ser un número.";
            const string MsgAverage = "Mitjana: ";
            const string MsgEvenCount = "Número de parells: ";
            const string MsgNotEvenCount = "Número de no parells: ";
            const int Size = 10;

            double[] arrayNum = new double[Size];
            double number = 0;
            double avg = 0;
            int oddCounter = 0;
            int evenCounter = 0;
            double sum = 0;

            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine();
                Console.WriteLine(MsgIntroduceNumber, i+1);
                
                if (!double.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine(MsgInputError);
                    i--;
                }
                else
                {
                    if (number % 2 == 0)
                    {
                        evenCounter++;
                    }
                    else if (number % 2 == 1)
                    {
                        oddCounter++;
                    }
                    arrayNum[i] = number;
                    sum += number;
                }
            }
            Console.WriteLine();

            // Mitjana
            avg = sum / Size;
            Console.WriteLine(MsgAverage + avg);
            Console.WriteLine();

            // Parells
            Console.WriteLine(MsgEvenCount + evenCounter);
            Console.WriteLine();

            // No parells
            Console.WriteLine(MsgNotEvenCount + oddCounter);
            Console.WriteLine();
        }
    }
}
