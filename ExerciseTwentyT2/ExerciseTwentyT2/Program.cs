using System;

namespace Convocatoria2
{
    /* 20. Demana 8 números i mostra:
    El número més gran
    El número més petit
    La mitjana
     */
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceNumber = "Introdueix un número a la posició [{0}]: ";
            const string MsgInputError = "Error. El valor ha de ser un número. ";
            const string MsgBiggestNumber = "Número més gran: {0}";
            const string MsgSmallestNumber = "Número més petit: {0}";
            const string MsgAvgResult = "Mitjana: {0}";
            const int Size = 8;

            double[] inputNumbers = new double[Size];
            double inputNumber = 0;
            double sum = 0;
            double avg = 0;
            double lowestNumber = 0;
            double biggestNumber = 0;

            // Demanar i validar números
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine(MsgIntroduceNumber, i+1);
                if (!double.TryParse(Console.ReadLine(), out inputNumber))
                {
                    Console.WriteLine();
                    Console.WriteLine(MsgInputError);
                    i--;
                }
                else
                {
                    inputNumbers[i] = inputNumber;
                    sum += inputNumber;
                }  
            }
            Console.WriteLine();

            // Mostrar més gran
            biggestNumber = inputNumbers[0];

            foreach (var number in inputNumbers)
            {
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }
            Console.WriteLine(MsgBiggestNumber, biggestNumber);
            Console.WriteLine();

            // Mostrar més petit
            lowestNumber = inputNumbers[0];

            foreach(var number in inputNumbers)
            {
                if (number < lowestNumber)
                {
                    lowestNumber = number;
                }
            }
            Console.WriteLine(MsgSmallestNumber, lowestNumber);
            Console.WriteLine();

            // Mostrar mitjana
            avg = sum / Size;

            Console.WriteLine(MsgAvgResult, avg);
            Console.WriteLine();
        }
    }
}