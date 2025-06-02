using System;

namespace Convocatoria2
{
    /* 13. Demana un número a l'usuari i mostra la seva taula de multiplicar del 1 al 10. */
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceNumber = "Introdueix un número per veure la seva taula de multiplicar: ";
            const string MsgInputError = "Error. El número ha de ser un natural.";
            const string MsgResult = "Taula de multiplicar del número: ";
            const int Size = 10;

            int inputNumber = 0;

            // Demanar número i validar
            Console.WriteLine(MsgIntroduceNumber);
            while(!int.TryParse(Console.ReadLine(), out inputNumber) || inputNumber <= 0)
            {
                Console.WriteLine();
                Console.WriteLine(MsgInputError);
            }
            Console.WriteLine();

            // Mostrar taula de multiplicar
            Console.WriteLine(MsgResult);

            for (int i = 0; i <= Size; i++)
            {
                Console.WriteLine($"{inputNumber} * {i} = {inputNumber*i}");
            }
            Console.WriteLine();
        }
    }
}