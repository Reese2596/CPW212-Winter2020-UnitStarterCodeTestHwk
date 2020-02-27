using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212_UnitTestStarterCode
{
    /*****************************************************************************
     * 
     * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
     * 
     * ***************************************************************************/
    public static class SimpleMath
    {

        /// <summary>
        /// Adds to valid numbers together and return their total.
        /// </summary>
        public static double Add(double a, double b)
        {
            double sum = a + b;
            return sum;
        }

        /// <summary>
        /// Subtract to valid numbers together and return their total.
        /// </summary>
        public static double Subtract(double a, double b)
        {
            double difference = a - b;
            return difference;
        }

        /// <summary>
        /// Multiply to valid numbers together and return their total.
        /// </summary>
        public static double Multiply(double a, double b)
        {
            double product = a * b;
            return product;
        }

        /// <summary>
        /// Divide to valid numbers together and return their total.
        /// </summary>
        public static double Divide(double a, double b)
        {
            if(b == 0)
            {
                throw new ArgumentException("Denominator cant be zero.");
            }
            else
            {
                double quotient = a / b;
                return quotient;
            }
            
        }
    }
}
