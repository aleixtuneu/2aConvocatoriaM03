using System;
using System.Globalization;

namespace Convocatoria2
{
    /* 11. Demana a l’usuari una data en format dd/MM/yyyy. Mostra si és una data vàlida i en quin dia de la setmana cau. */
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceDate = "Introdueix una data en el format dd/MM/yyyy: ";
            const string MsgValidDate = "La data {0} és vàlida.";
            const string MsgInvalidDate = "La data {0} no és vàlida.";
            const string MsgResult = "Cau en: {0}";

            string inputDate = "";
            DateTime validDate = new DateTime();
            CultureInfo cultureCat = new CultureInfo("ca-Es");

            // Demanar data
            Console.WriteLine(MsgIntroduceDate);
            inputDate = Console.ReadLine();
            Console.WriteLine();

            if (DateTime.TryParseExact(inputDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out validDate))
            {
                Console.WriteLine(MsgValidDate);

                // Mostrar dia de la setmana en català
                Console.WriteLine(MsgResult, validDate.ToString("dddd", cultureCat));
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(MsgInvalidDate);
                Console.WriteLine();
            }
        }
    }
}
