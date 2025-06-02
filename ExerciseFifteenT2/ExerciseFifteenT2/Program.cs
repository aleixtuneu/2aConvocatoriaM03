using System;

namespace Convocatoria2
{
    /* 15. Crea una funció que rebi un número i retorni el seu quadrat. Demostra el seu funcionament des del Main. */
    public class Program
    {
        public static void Main()
        {
            const string MsgResult = "Resultat de {0} al quadrat: {1}";

            int inputNumber = 2;

            Console.WriteLine(MsgResult, inputNumber, SquareNumber(inputNumber));
            Console.WriteLine();
        }

        public static double SquareNumber(int pNumber)
        {
            return Math.Pow(pNumber, 2); ;
        }
    }
}