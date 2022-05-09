using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class TicketsException : ApplicationException
    {
        public TicketsException(string s) : base(s)
        {

        }
    }
    class Passanger
    {
        public string Name;
        public int Age;
        public DateTime DateofTravel;
        public int no_of_tickets;
        public Passanger(string Name, int Age, DateTime DateofTravel)
        {
            this.Name = Name;
            this.Age = Age;
            this.DateofTravel = new DateTime();
            Console.WriteLine("Name of passenger" + Name + " age is " + 21 + " date of travel is " + DateofTravel);
        }
        public static void TicketBooking(int no_of_tickets)
        {
            if (no_of_tickets > 5)
            {
                throw (new TicketsException("Cannot book more than 5 tickets!!!"));
            }
            else
            {
                Console.WriteLine("Ticket Booked Successfully!!!");
            }
        }
    }
    class Test
    {
        public static void main(string[] args)
        {
            Passanger passanger = new Passanger("krishna", 21, new DateTime(2022, 05, 30));
            try
            {
                Passanger.TicketBooking(3);
            }
            catch (TicketsException t)
            {
                Console.WriteLine(t.Message);
            }
            Console.ReadLine();
        }

    }
}