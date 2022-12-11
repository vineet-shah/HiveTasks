using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiveTasks
{
    class Calculator
    {
        internal const string ADDITION = "+";
        internal const string SUBSTRACTION = "-";
        internal const string DIVISION_FORWARD = "/";
   
        // Here the back slash will acts as escape character and we would be utizing " as division operator!
        // Not aware about " being used as division operator. If the intention was to use backlash we would need to put it up as "\\"
        public const string DIVISION_BACKWARD = "\"";           
   
        public const string MULTIPLICATION = "*";

        public void Addition(int a, int b)
        {
            Console.WriteLine($"{ a + b }");
        }

        public void Substraction(int a, int b)
        {
            Console.WriteLine($"{ a - b }");
        }

        public void Division(int a, int b)
        {
            if (b == 0) Console.WriteLine("Zero Divide");
            else Console.WriteLine($"{ a / b }");
        }

        public void Multiplication(int a, int b)
        {
            Console.WriteLine($"{ a * b }");
        }
    }
}
