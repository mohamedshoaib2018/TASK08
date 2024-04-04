using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace TASK08
{
    internal static class Math_s
    {
        public static double Power2 (double num) 
        {
            double result = num * num;
            return result; 
        }

         public static double PowerMultible(double num,int powerOf)
         {
            double result = 1;
            
            for (int i = 1; i <= powerOf; i++)
            {
                result = result * num;
            }
            return result;
        }
        public static double SquareRoot(double num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Cannot calculate square root of a negative number");
            }

            if (num == 0)
            {
                return 0;
            }

            double x = num;
            double epsilon = 0.000001; 

            while (true)
            {
                double nextX = 0.5 * (x + num / x); // Newton-Raphson method
                if (Math.Abs(nextX - x) < epsilon)
                {
                    return nextX;
                }
                x = nextX;
            }
        }


        public static double Max(double num1, double num2)
        {
            double result;
            if (num1 > num2) { result = num1; }
            else { result = num2; }
            return result;
        }

        public static double Min(double num1, double num2)
        {
            double result;
            if (num1 < num2) { result = num1; }
            else { result = num2; }
            return result;
        }

        public static decimal Absolute(decimal num1)
        {
            decimal result = 0;
            if (num1 >= 0) { result = num1; }
            else if (num1 < 0) { result = num1 * -1; }
            
            return result;
        }


    }
    
}
