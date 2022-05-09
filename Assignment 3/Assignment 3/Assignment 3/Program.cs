using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // student marks program
            Student_data student = new Student_data(1234, "sharif", "Btech", "1stsem", "mech");
            student.displaydata();
            student.displayresult();

            // car program

            cars car = new cars(0007, "rollsroyce", "boattail");
            car.displaycardetails();
            cars car2 = new cars(500000);

            // Loan amount calculator

            Interest_Amount ia = new Interest_Amount();
            ia.loanCalculator(200000);
            Console.ReadLine();
        }
    }
    
}
