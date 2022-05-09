using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__4
{
    class Program
    {
        public class Students
        {
            public int st_Id;
            public string st_Name;
            public double exam_fee;


            public void displayDetails()
            {
                Console.WriteLine($"\nthe student {st_Name} with id {st_Id} paid {exam_fee}");
            }
            public void payFee()
            {
                Console.WriteLine("\nenter student id: ");
                st_Id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the student name: ");
                st_Name = Console.ReadLine();
                Console.WriteLine("the exam fee: is" + 1000);
                Console.WriteLine("enter the amount to pay examfee");
                exam_fee = int.Parse(Console.ReadLine());
                double rem_fee = 1000 - exam_fee;
                if (exam_fee == 1000)
                {
                    Console.WriteLine("full fees paid no dues");
                }
                else
                {
                    Console.WriteLine("the remaining fee: " + rem_fee);
                }
            }
        }
        class DayScholar
        {
            public double transport_fees;

            public DayScholar(double transport_fees)
            {
                this.transport_fees = transport_fees;
                double rem1_fee = 20000 - transport_fees;

                Console.WriteLine("\nthe transport fee: " + 20000 + "per year ");


                Console.WriteLine($"the dayscholar  paid {transport_fees} & remaining fee is {rem1_fee}");
                Console.WriteLine();
            }

        }
        public class Hosteller
        {
            public double hostel_fee;

            public Hosteller(double hostel_fee)
            {

                this.hostel_fee = hostel_fee;

                double rem2_fee = 30000 - hostel_fee;
                Console.WriteLine("the hostel  fee: " + 30000 + "per year ");

                Console.WriteLine($"the dayscholar  paid {hostel_fee} & remaining fee is {rem2_fee} ");
                Console.WriteLine();
            }
        }





        static void Main(string[] args)
        {
            Students students = new Students();
            students.payFee();
            students.displayDetails();
            Console.WriteLine("enter the tranport fee you want to pay: ");
            DayScholar dayScholar = new DayScholar(int.Parse(Console.ReadLine()));
            Console.WriteLine("enter the hostel fee you want to pay: ");
            Hosteller hosteller = new Hosteller(int.Parse(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
