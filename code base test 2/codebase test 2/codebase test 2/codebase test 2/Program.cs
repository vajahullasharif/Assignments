using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebase_test_2
{
    namespace ConsoleApp1
    {
        public delegate int operation(int a, int b);
        class Program
        {

            static int Addition(int a, int b)
            {
                return a + b;
            }

            static int subtract(int a, int b)
            {
                return a - b;
            }

            static int multiplication(int a, int b)
            {
                return a * b;
            }

            static void Main(string[] args)
            {
                int integer1, integer2;
                Console.Write("Enter integer - 1: ");
                integer1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter integer - 2: ");
                integer2 = Convert.ToInt32(Console.ReadLine());
                operation AddObj = new operation(Program.Addition);
                operation SubObj = new operation(Program.subtract);
                operation MulObj = new operation(Program.multiplication);
                Console.WriteLine("Addition is={0}", AddObj(integer1, integer2));
                Console.WriteLine("Subtraction is={0}", SubObj(integer1, integer2));
                Console.WriteLine("Mutliplication is={0}", MulObj(integer1, integer2));
                Console.ReadLine();
            }
        }
    }
}
