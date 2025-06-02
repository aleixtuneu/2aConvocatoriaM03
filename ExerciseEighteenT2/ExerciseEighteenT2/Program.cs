using System;

namespace Convocatoria2
{
    /* 18. Crea un programa que:
    Demani 5 paraules i les guardi en un array
    Mostri les paraules en ordre invers
     */
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceWord = "Introdueix la paraula [{0}]: ";
            const string MsgResult = "Paraules en ordre invers: ";
            const int Size = 5;

            string inputWord = "";
            string[] inputWords = new string[Size];

            // Demanar 5 paraules
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine(MsgIntroduceWord, i+1);
                inputWord = Console.ReadLine();
                inputWords[i] = inputWord;
                Console.WriteLine();
            }
            Console.WriteLine();

            // Mostrar paraules en ordre invers
            Console.WriteLine(MsgResult);
            for (int i = inputWords.Length-1; i >= 0; i--)
            {
                Console.WriteLine(inputWords[i]);
            }
            Console.WriteLine();
        }
    } 
}