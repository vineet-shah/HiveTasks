using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiveTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Things: ");
            string[] num = inputArray();

            PeformTheMath(num);
            Console.ReadLine();
        }

        /// <summary>
        /// This method is validation method which makes sure that user has enter three inputs.
        /// </summary>
        /// <param name="num"></param>
        /// <returns> an array with user provided input which of length 3 </returns>
        private static string[] inputArray()
        {
            string[] num = Console.ReadLine().Trim().Split(' ');
            
            if (num.Length == 3)
            {
                bool isnum1 = int.TryParse(num[0], out _);
                bool isnum2 = int.TryParse(num[2], out _);

                if (!isnum1 || !isnum2)
                {
                    num = Array.Empty<string>();
                }
            }

            while (num.Length != 3)
            {
                Console.WriteLine("Please enter all numbers: ");
                num = Console.ReadLine().Split(' ');

                if (num.Length == 3)
                {
                    bool isnum1 = int.TryParse(num[0], out _);
                    bool isnum2 = int.TryParse(num[2], out _);

                    if (!isnum1 || !isnum2)
                    {
                        num = Array.Empty<string>();
                    }
                }
            }

            return num;
        }

        /// <summary>
        /// Method to perform the mathematical operations
        /// </summary>
        /// <param name="num"> array of user input</param>
        private static void PeformTheMath(string[] num)
        {
            Calculator calc = new Calculator();
            string mathOperator = num[1];

            int num1 = int.Parse(num[0]);
            int num2 = int.Parse(num[2]);

            switch (mathOperator)
            {
                case Calculator.ADDITION:
                    calc.Addition(num1, num2);
                    break;

                case Calculator.SUBSTRACTION:
                    calc.Substraction(num1, num2);
                    break;

                case Calculator.MULTIPLICATION:
                    calc.Multiplication(num1, num2);
                    break;

                case Calculator.DIVISION_BACKWARD:
                case Calculator.DIVISION_FORWARD:
                    calc.Division(num1, num2);
                    break;

                default:
                    Console.WriteLine("Invalid operation provided.");
                    break;
            }
            
        }
    }
}
