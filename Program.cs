using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;

    class Program
    {
        delegate double Function(double x);

        static void Main()
        {
            Console.Write("Введіть значення x: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double x))
            {
                Function function;

                if (x > 0)
                    function = CosineFunction;
                else
                    function = SineFunction;

                double result = function(x);
                Console.WriteLine($"F({x}) = {result}");
            }
            else
            {
                Console.WriteLine("Потрібно було ввести число");
            }
        }

        static double CosineFunction(double x) => Math.Cos(x + 1);
        static double SineFunction(double x) => 1 - 2 * Math.Sin(x);
    }

}
