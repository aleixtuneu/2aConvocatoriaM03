using System;

namespace Convocatoria2
{
    /* 23. Implementa i testeja amb MsTest una funció IsEven(int num) que retorni true si és parell i false en cas contrari. */
    public class NumberUtils
    {
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}