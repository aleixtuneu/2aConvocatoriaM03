using System;

namespace Convocatoria2
{
    /* 22. Fes un joc on:
    L'ordinador generi un número aleatori entre 1 i 50
    L'usuari hagi d'endevinar-lo
    El programa digui "Més alt" o "Més baix" fins que l'encerti
    Mostri el nombre d'intents necessaris
     */
    public class Program
    {
        public static void Main()
        {
            const string MsgAttempt = "Intent [{0}].";
            const string MsgIntroduceNumber = "Introdueix un número: ";
            const string MsgInputError = "Error. El valor ha de ser un número.";
            const string MsgBigger = "Més alt.";
            const string MsgSmaller = "Més baix.";
            const string MsgOk = "Has encertat!";

            Random randomGenerator = new Random();
            int secretNumber = randomGenerator.Next(1, 51); // Generar numero aleatori entre 1 i 50
            int attempts = 0;
            bool isCorrect = false;
            int inputNumber = 0;

            while (!isCorrect)
            {
                // Mostrar intent
                Console.WriteLine(MsgAttempt, attempts+1);

                // Demanar i validar número
                Console.WriteLine(MsgIntroduceNumber);
                if(!int.TryParse(Console.ReadLine(), out inputNumber))
                {
                    Console.WriteLine();
                    Console.WriteLine(MsgInputError);
                }
                else
                {
                    Console.WriteLine();

                    if (inputNumber > secretNumber)
                    {
                        Console.WriteLine(MsgSmaller);
                        attempts++;
                    }
                    else if (inputNumber < secretNumber)
                    {
                        Console.WriteLine(MsgBigger);
                        attempts++;
                    }
                    else
                    {
                        Console.WriteLine(MsgOk);
                        isCorrect = true;
                    }
                    Console.WriteLine();
                }
            }




        }
    }
}