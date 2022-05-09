using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__4
{
    class Emp
    {
        public int EmpId;
        public string EmpName;
        public float salary;

        public Emp(int Id, string Name, float salary)
        {
            this.EmpId = Id;
            this.EmpName = Name;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine($"\nempName {EmpName} with empid {EmpId} gets salary of {salary}");
        }
    }
    public class PartTimeemployees
    {
        public float wages = 1900.00f;

        public void show()
        {
            Console.WriteLine("the parttime employee gets " + wages);

        }
        class Employees
        {
            static void Main(string[] args)
            {
                Emp employee = new Emp(123, "lokesh", 1000.3f);
                employee.display();
                PartTimeemployees pte = new PartTimeemployees();
                pte.show();
                Console.ReadLine();
            }
        }
    }
}
