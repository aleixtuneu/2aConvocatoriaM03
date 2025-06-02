using System;

namespace Convocatoria2
{
    /* 19. Fes un programa que demani un número enter i calculi la suma dels seus dígits. */
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceNumber = "Introdueix un número enter: ";
            const string MsgInputError = "Error. El número ha de ser enter.";
            const string MsgResult = "Suma dels seus dígits: {0}";

            int inputNumber = 0;
            string inputString = "";
            int result = 0;

            // Demanar número i validar
            Console.WriteLine(MsgIntroduceNumber);
            while(!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.WriteLine();
                Console.WriteLine(MsgInputError);
            }
            Console.WriteLine();

            // Calcular suma dels seus dígits
            inputString = Math.Abs(inputNumber).ToString();
            foreach(char digit in inputString)
            {
                result += int.Parse(digit.ToString());
            }

            // Mostrar resultat
            Console.WriteLine(MsgResult, result);
            Console.WriteLine();
        }
    }
}