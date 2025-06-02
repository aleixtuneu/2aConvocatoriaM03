using System;

namespace Convocatoria2
{
    /* Ex.9 */
    public class Program
    {
        public static void Main()
        {
            int x = 4;
            int y = 7;
            bool p = true;
            bool q = false;

            // Expressió b)
            bool resultat_b = (x + y) % 3 == 0 || p != q;
            Console.WriteLine($"Resultat b): {resultat_b}"); // Esperat: True

            // Expressió c)
            bool resultat_c = !(x * y < 30) && p;
            Console.WriteLine($"Resultat c): {resultat_c}"); // Esperat: False

            Console.WriteLine("Depuració finalitzada. Prem una tecla per sortir.");
            Console.ReadKey(); // Punt per posar un breakpoint
        }
    }
}