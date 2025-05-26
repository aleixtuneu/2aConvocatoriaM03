using System;

namespace Convocatoria2
{
    /* Ex.8 */
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceSize = "Quants nombres vols introduïr? ";
            const string MsgInputIntError = "Error. El valor ha de ser un enter positiu.";
            const string MsgInputNumberError = "Error. El valor ha de ser un número.";
            const string MsgIntroduceNumber = "Introdueix un número a la posició {0}: ";
            const string MsgResult = "Mitjana dels números introduïts: {0}.";

            int size = 0;
            double avg = 0;
            double inputNumber = 0;
            double sum = 0;

            // Demanar quants nombres vol introduïr i validar
            Console.WriteLine(MsgIntroduceSize);
            while(!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine();
                Console.WriteLine(MsgInputIntError);
            }
            Console.WriteLine();

            // Demanar nombres un per un
            for (int i = 0; i < size; i++)
            {
                // Validar número
                Console.WriteLine(MsgIntroduceNumber, i+1);
                while(!double.TryParse(Console.ReadLine(), out inputNumber))
                {
                    Console.WriteLine();
                    Console.WriteLine(MsgInputNumberError);
                }
                Console.WriteLine();

                // Sumar número al total
                sum += inputNumber;
            }

            // Calcular mitjana
            avg = sum / size;

            // Mostrar resultat
            Console.WriteLine(MsgResult, avg);
        }
    }
}