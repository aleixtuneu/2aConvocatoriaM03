using System;

namespace Convocatoria2
{
    /* 9. Implementa una funció que comprovi que una contrasenya:
    Té entre 8 i 12 caràcters
    Inclou almenys una majúscula, una minúscula i un número
    No contingui espais
     */
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroducePassword = "Introdueix una contrassenya: ";
            const string MsgLengthOk = "Té entre 8 i 12 caràcters.";
            const string MsgLengthKo = "No té entre 8 i 12 caràcters";
            const string MsgUpperLowerNumOk = "Inclou almenys una majúscula, una minúscula i un número.";
            const string MsgUpperLowerNumKo = "No inclou almenys una majúscula, una minúscula i un número.";
            const string MsgNotSpaceOk = "No conté espais.";
            const string MsgNotSpaceKo = "Conté espais.";
            const int MinLength = 8;
            const int MaxLength = 12;

            string inputPassword = "";
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNum = false;
            bool hasSpace = false;


            // Introduir contrasenya
            Console.WriteLine(MsgIntroducePassword);
            inputPassword = Console.ReadLine();
            Console.WriteLine();

            // Validar llargada
            Console.WriteLine(inputPassword.Length >= MinLength && inputPassword.Length <= MaxLength ? MsgLengthOk : MsgLengthKo);
            
            // Validar minúscula, majúscula i número
            foreach( char c in inputPassword)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(c))
                {
                    hasLower = true;
                }
                else if (char.IsDigit(c))
                {
                    hasNum = true;
                }
                else if (char.IsWhiteSpace(c))
                {
                    hasSpace = true;
                }
            }

            if (hasUpper && hasLower && hasNum)
            {
                Console.WriteLine(MsgUpperLowerNumOk);
            }
            else
            {
                Console.WriteLine(MsgUpperLowerNumKo);
            }

            // Validar espais
            Console.WriteLine(hasSpace ? MsgNotSpaceKo : MsgNotSpaceOk);
            Console.WriteLine();
        }
    }
}
