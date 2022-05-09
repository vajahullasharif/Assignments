using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__4
{
    public abstract class Students
    {



        int studentid;
        string studentname;
        public abstract bool IsPass(float grade);



        public void studentdatails()
        {
            Console.WriteLine("Enter the student details id and name : ");
           this. studentid = int.Parse(Console.ReadLine());
           this. studentname = Console.ReadLine();
        }
        public void showdetails()
        {
            Console.WriteLine($"The student details is studentid is {studentid}, studentname is {studentname}");
        }



    }



    class Graduate : Students
    {
        public override bool IsPass(float g)
        {
            float result = g;
            if (result <= 70.0f)
                return false;
            return true;
        }
    }



    class UG : Students
    {
        public override bool IsPass(float g)
        {
            float result = g;
            if (result <= 80.0f)
                return false;
            return true;
        }
    }

    class Student
    {
        static void Main(String[] args)
        {
            Graduate g = new Graduate();
            g.studentdatails();
            g.showdetails();
            Console.WriteLine(g.IsPass(75.0f));



            // under graduate details
            UG ug = new UG();
            ug.studentdatails();
            ug.showdetails();
            Console.WriteLine(ug.IsPass(79.0f));
            Console.Read();
        }
    }
}
