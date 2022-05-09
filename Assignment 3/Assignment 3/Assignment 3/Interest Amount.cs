using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Interest_Amount
    {
        double rate;

        public void loanCalculator(double loanamt)
        {
            Console.WriteLine("Enter rate of interest");
            rate = Convert.ToDouble(Console.ReadLine());
            double interest = (loanamt * rate) / 100;
            Console.WriteLine("Rate of interest for " + rate + "%  is : " + interest);
        }
    }
}

