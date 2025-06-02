using System;

namespace Convocatoria2
{
    /* 10. Comprova que una cadena tingui 8 dígits seguits d’una lletra (no cal validar la lletra final). */
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceString = "Introdueix una cadena (string): ";
            const string MsgStringOk = "La cadena té 8 dígits seguits d’una lletra.";
            const string MsgStringKo = "La cadena no té 8 dígits seguits d’una lletra.";

            string inputString = "";

            // Demanar cadena
            Console.WriteLine(MsgIntroduceString);
            inputString = Console.ReadLine();
            Console.WriteLine();

            // Validar cadena
            Console.WriteLine(IsValidString(inputString) ? MsgStringOk : MsgStringKo);
            Console.WriteLine();
        }

        public static bool IsValidString(string pInputString)
        {
            // Comprovar si la cadena és nul·la o buida
            if (string.IsNullOrEmpty(pInputString))
            {
                return false;
            }

            // Comprovar si la longitud és 9
            if (pInputString.Length != 9)
            {
                return false;
            }

            // Comprovar que els primers 8 caràcters siguin digits
            for (int i = 0; i < 8; i++)
            {
                if (!char.IsDigit(pInputString[i]))
                {
                    return false;
                }
            }

            // Comprovar que el novè caràcter sigui una lletra
            if (!char.IsLetter(pInputString[8]))
            {
                return false;
            }

            // Si les comprovacions anteriors han passat
            return true;
        }
    }
}