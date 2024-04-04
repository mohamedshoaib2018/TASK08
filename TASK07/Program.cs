using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Example for Power 2 static Method");
            Console.WriteLine("Enter a number");
            string num1 = Console.ReadLine();
            Console.WriteLine($"The value of the Method is {Math_s.Power2(double.Parse(num1))}");
            Console.WriteLine("\n\n");
            Console.WriteLine("Example for Multible Power static Method");
            Console.WriteLine("Enter the number value");
            string num2 = Console.ReadLine();
            Console.WriteLine("Enter the power value");
            string num3 = Console.ReadLine();
            Console.WriteLine($"The value of the Method is {Math_s.PowerMultible(int.Parse(num2), int.Parse(num3))}");
            Console.WriteLine("\n\n");
            Console.WriteLine("Example for squareRoot static Method");
            Console.WriteLine("Enter a number");
            double num4 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The value of the Method is {Math_s.SquareRoot(num4)}");
            Console.WriteLine("\n\n");
            Console.WriteLine("Example for Max Number static Method");
            Console.WriteLine("Enter the first number");
            double num5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double num6 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The value of the Method is {Math_s.Max(num5, num6)}");
            Console.WriteLine("\n\n");
            Console.WriteLine("Example for Min Number static Method");
            Console.WriteLine("Enter the first number");
            double num7 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double num8 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The value of the Method is {Math_s.Min(num7, num8)}");
            Console.WriteLine("\n\n");
            Console.WriteLine("Example for Absolute static Method");
            Console.WriteLine("Enter a number with negative sign");
            int num9 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The value of the Method is {Math_s.Absolute(num9)}");
        }
        
    }
}
