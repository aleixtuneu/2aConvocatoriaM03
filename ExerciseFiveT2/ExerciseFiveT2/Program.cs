using System;
using System.Data;

namespace Convocatoria2
{
    /* 5.  Implementa un programa que retorni per pantalla el factorial d’un número introduït per teclat i si aquest és primer o no (de manera iterativa i de manera recursiva). */
    public class Program
    {
        const string MsgNegative = "El factorial no està definit per a nombres negatius.";

        // Factorial
        public static long FactorialIterative(int n)
        {
            long result = 0;

            if (n < 0)
            {
                Console.WriteLine(MsgNegative);
            }

            if (n == 0 || n == 1)
            {
                return 1;
            }

            result = 1;

            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static long FactorialRecursive(int n)
        {
            if (n < 0)
            {
                Console.WriteLine(MsgNegative);
            }

            if (n == 0 || n == 1)
            {
                return 1;
            }

            return n * FactorialRecursive(n - 1);
        }

        // Nombre primer
        public static bool IsPrimeIterative(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static bool IsPrimeRecursive(int n, int divider = 2)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % divider == 0 && n != divider) return false;
            if (divider * divider > n) return true;

            return IsPrimeRecursive(n, divider + 1);
        }

        public static void Main()
        {
            const string MsgInputNumber = "Introdueix un número: ";
            const string MsgFactorialIterative = "Factorial de {0} (iteratiu): {1}";
            const string MsgFactorialRecursive = "factroial de {0} (recursiu): {1}";
            const string MsgIsPrimeIterative = "{0} és primer (iteratiu)? {1}";
            const string MsgIsPrimerRecursive = "{0} és primer (recursiu)? {1}";
            const string MsgInvalidInput = "Entrada invàlida.";

            int num = 0;

            Console.WriteLine(MsgInputNumber);

            if (int.TryParse(Console.ReadLine(), out num))
            {
                if (num < 0)
                {
                    Console.WriteLine(MsgNegative);
                }
                else
                {
                    Console.WriteLine(MsgFactorialIterative, FactorialIterative(num));
                    Console.WriteLine();
                    
                    Console.WriteLine(MsgFactorialRecursive, FactorialRecursive(num));
                    Console.WriteLine();

                    Console.WriteLine(MsgIsPrimeIterative, num, IsPrimeIterative(num));
                    Console.WriteLine();

                    Console.WriteLine(MsgIsPrimerRecursive, num, IsPrimeRecursive(num));
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine(MsgInvalidInput);
            }
            Console.WriteLine();
        }
    }
}
