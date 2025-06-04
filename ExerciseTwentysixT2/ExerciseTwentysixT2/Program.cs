using System;

namespace Convocatoria2
{
    public class Program
    {
        public static void Main()
        {
            const string MsgIsEven = "És parell.";
            const string MsgIsOdd = "És senar.";
            const int Divider = 2;
            
            int inputNumber = 5; // Defineix el número que volem comprovar

            // Comprova si el número és parell o senar, un número és parell si el residu de la divisió per 2 és 0.
            // Si és parell, imprimeix 'És parell'. Si és senar, imprimeix 'És senar.' 
            Console.WriteLine(inputNumber % Divider == 0 ? MsgIsEven : MsgIsOdd);
        }
    }
}