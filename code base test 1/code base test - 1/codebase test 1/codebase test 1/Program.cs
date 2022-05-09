using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebase_test_1

{
    public class TicketsException : Exception
    {
        public TicketsException(string message) : base(message)
        {
        }
    }
    class Passenger
    {
        string name;
        string DateofTravel;
        int Age;
        Passenger(string name, string DateofTravel, int Age)
        {
            this.name = name;
            this.DateofTravel = DateofTravel;
            this.Age = Age;
        }

        public void TicketBooking(int no_of_tickets)
        {
            Console.WriteLine($"The passenger details is Age {Age}, Name is {name}, Date of travel is {DateofTravel}, no.of tickets is {no_of_tickets}");
            if (no_of_tickets > 5)
            {
                throw (new TicketsException("No more than 5 tickets"));
            }
            else
            {
                Console.WriteLine("Tickets successfully: {0}", no_of_tickets);

            }
        }

<<<<<<< HEAD

        public static void Main(String[] args)
=======
        public static void Main()
>>>>>>> be71923cce240a46f00fc76fd1998d2b37c58021
        {
            int no_tickets;
            no_tickets = Convert.ToInt32(Console.Read());
            Console.WriteLine(no_tickets);
            Passenger pass = new Passenger("Vajahulla", "5-05-2022", 22);
<<<<<<< HEAD
            try {
                pass.TicketBooking(no_tickets);
            }
            catch (TicketsException te)
            {
                Console.WriteLine(te.Message);
            }

            Console.Read();
=======
            pass.TicketBooking(no_tickets);
            
>>>>>>> be71923cce240a46f00fc76fd1998d2b37c58021
        }
    }
}


    
   


        
    

