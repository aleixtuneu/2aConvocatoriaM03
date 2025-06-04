using System;

namespace Convocatoria2
{
    public class Program
    {
        // Mètode principal per demostrar l'ús
        public static void Main(string[] args)
        {
            const string MsgOriginalArray = "Array original: {0}";
            const string MsgSortedArray = "Array ordenat: {0}";

            int[] numbersToSort = { 3, 4, 1, 5, 2 }; // Nom més descriptiu per a l'array

            Console.WriteLine(MsgOriginalArray, string.Join(",", numbersToSort));

            SortAscending(numbersToSort); // Mètode per ordenar

            Console.WriteLine(MsgSortedArray, string.Join(",", numbersToSort));
        }

        /// <summary>
        /// Ordena un array d'enters en ordre ascendent utilitzant l'algorisme Bubble Sort.
        /// Modifica l'array original (ordenació in-place).
        /// </summary>
        /// <param name="numbers">L'array d'enters a ordenar.</param>

        public static void SortAscending(int[] numbers)
        {
            int N = numbers.Length;

            if (numbers != null)
            {
                // El bucle exterior itera N-1 vegades.
                // En cada passada, l'element més gran "bombolleja" cap a la seva posició final correcta.
                for (int i = 0; i < N - 1; i++)
                {
                    // El bucle interior compara elements adjacents.
                    // La longitud del bucle interior disminueix a cada passada del bucle exterior,
                    // ja que els elements al final de l'array ja estan ordenats.
                    for (int j = 0; j < N - i - 1; j++)
                    {
                        // Compara elements adjacents
                        if (numbers[j] > numbers[j + 1])
                        {
                            // Intercanvia numbers[j] i numbers[j+1]
                            Swap(numbers, j, j + 1);
                        }
                    }
                    // Sense la comprovació 'swapped' i el 'break', aquest bucle exterior
                    // sempre completarà totes les seves N-1 iteracions.
                }
            }
            else
            {
                Console.WriteLine();
            }     
        }

        /// <summary>
        /// Intercanvia dos elements dins d'un array.
        /// </summary>
        /// <param name="array">L'array que conté els elements.</param>
        /// <param name="index1">L'índex del primer element.</param>
        /// <param name="index2">L'índex del segon element.</param>
        private static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}