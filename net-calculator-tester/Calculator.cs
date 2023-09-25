using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public static class Calculator
    {
        // Metodo per la somma di due numeri float
        public static float Add(float num1, float num2) 
        {
            return num1 + num2; 
        }

        // Metodo per la sottrazione di due numeri float
        public static float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        // Metodo per la divisione di due numeri float

        public static float Divide(float num1, float num2)
        {
            if (num2 == 0)
            {
                throw new Exception("Non puoi dividere per il numero 0");
            }
            return num1 / num2;
        }


        // Metodo per la moltiplicazione di due numeri float
        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}
