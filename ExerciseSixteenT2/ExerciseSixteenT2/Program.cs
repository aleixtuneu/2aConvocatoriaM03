using System;

namespace Convocatoria2
{
    /* 16. Fes un programa que demani un número entre 1 i 100. Si l'usuari introdueix un número fora d'aquest rang o un valor no numèric, torni a demanar-lo fins que sigui correcte. */
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceNumber = "Introdueix un número dins en el rang [1-100]: ";
            const string MsgInputError = "Error, el valor ha de ser un número i estar dins el rang.";
            const string MsgOk = "El número introduït està dins el rang [1-100].";
            const int Max = 100;
            const int Min = 1;

            double inputNumber = 0;

            // Demanar i validar número
            Console.WriteLine(MsgIntroduceNumber);
            while (!double.TryParse(Console.ReadLine(), out inputNumber) || inputNumber < Min || inputNumber > Max)
            {
                Console.WriteLine();
                Console.WriteLine(MsgInputError);
            }
            Console.WriteLine();

            // Mostrar confirmació
            Console.WriteLine(MsgOk);
            Console.WriteLine();
        }
    }
}
