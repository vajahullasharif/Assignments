using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter array size");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter array values");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array value of : " + i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array elements are");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Average of the given array is " + array.Average());
            Console.WriteLine("Maximum nuber in array is " + array.Max());
            Console.WriteLine("Minimum nuber in array is " + array.Min());

            //Ten Marks referance
            TenMarks te = new TenMarks();
            te.tenmarks();

            // String Class

            String_Assignment sa = new String_Assignment();
            sa.stringlength();
            //same strings 
            samestrings ss = new samestrings();
            ss.stringsameOrNot();
            //pallindrome 
            Pallindrome pa = new Pallindrome();
            pa.strPallindrome();
            Console.ReadLine();
        }
    }
}
