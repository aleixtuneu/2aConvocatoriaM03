using System;

namespace Convocatoria2
{
    /* 17. Demana 10 números per teclat, guarda'ls en un array i després demana un número a buscar. El programa ha de dir si aquest número es troba a l'array i en quina posició. */
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceNumber = "Introdueix un número a la posició [{0}]: ";
            const string MsgInputError = "Error, el valor ha de ser un número.";
            const string MsgIntroduceNumberToSearch = "Quin valor vols buscar? ";
            const string MsgResultOk = "El número es troba a l'array, a la posició [{0}].";
            const string MsgResultKo = "El número no es troba a l'array.";
            const int Size = 10;

            double[] inputNumbers = new double[Size];
            double inputNumber = 0;
            double numberToSearch = 0;
            bool found = false;

            // Demanar números i validar un per un
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine(MsgIntroduceNumber, i);

                if (!double.TryParse(Console.ReadLine(), out inputNumber))
                {
                    Console.WriteLine();
                    Console.WriteLine(MsgInputError);
                    i--;
                }
                Console.WriteLine();

                inputNumbers[i] = inputNumber;
            }

            // Demanar número per buscar i validar
            Console.WriteLine(MsgIntroduceNumberToSearch);
            while(!double.TryParse(Console.ReadLine(), out numberToSearch))
            {
                Console.WriteLine();
                Console.WriteLine(MsgInputError);
            }
            Console.WriteLine();

            // Buscar número
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i] == numberToSearch)
                {
                    // Mostrar posició
                    Console.WriteLine(MsgResultOk, i);
                    found = true;
                }
            }
            Console.WriteLine();

            if (found != true)
            {
                Console.WriteLine(MsgResultKo);
            }
            Console.WriteLine(); 
        }
    }
}