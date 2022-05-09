using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet5
{
    internal class BankException :ApplicationException
    {
        public BankException(string msg) : base(msg)
        {

        } 

    }
    
        class BankApplication
        {
            int Amount = 30000;
            static String Bank_name = "ICICI";
            static public int Total_balance;
            String Account_holder = "Sharif";
            String Account_number;
            public void Depositamount()
            {

                Console.WriteLine("Enter Your deposite  Amount :");
                int En_depositemoney = int.Parse(Console.ReadLine());
                Total_balance = Amount +En_depositemoney;
                if (En_depositemoney <= 100  )
                {
                    Console.WriteLine("Please Enter the minimum 100 rupees like...100,200,500,1000");
                }
                else
                {
                    Console.WriteLine("Total your account  balance is.... :{0}", Total_balance);
                }

            }
            public void WithdrawMoney()
            {
               
                   
                    Console.WriteLine("Please Enter Withdrawamount... :");
                    int Withdraw_Amount = int.Parse(Console.ReadLine());
                    
                     
                    if (Amount<Withdraw_Amount)
                    {
                        throw(New BankException("Insuffiecient Balance"));
                    }
                    else if (Withdraw_Amount< Amount && Withdraw_Amount%100==0 )
                      {
                         
                        int  Newtotal_balance= Amount - Withdraw_Amount;
                        Console.WriteLine("Take Your Cash  ...:{0} ",Withdraw_Amount);
                        Console.WriteLine("Your Remaing amount is ...:{0}", Newtotal_balance);
                    
                       }
                    else
                    { 
                        
                        Console.WriteLine("Please Enter the minimum 100 rupees like...100,200,500,1000");
                    }

                
                //catch (Exception e)
                //{
                  //  Console.WriteLine("Please Enter the valid numbers......");
                    //Console.WriteLine("Your Enter invalid choices ........");
                //}
            }
            public void Balance()
            {
                Console.WriteLine("Hi!...Welcome To {0} Bank ",Bank_name);
                Console.WriteLine("Please Enter Account Number.....: ");
                Account_number = Console.ReadLine();
                Console.WriteLine("Welcome {0} Your AccountBalance: {1}" ,Account_holder, Amount);

            }
        }



    class UserDefinedException 
    { 

        static void Main(string[] args)
        {
            BankApplication app= new BankApplication();
          
            try
            {
            Console.WriteLine("Welcome to bank.....");
            Console.WriteLine("Depositamount for 1.....");
            Console.WriteLine(" WithdrawMoney for 2.....");
            Console.WriteLine(" Balance for 3.....");
            Console.WriteLine("Select Your Option .....:");
            int option=int.Parse(Console.ReadLine());
                else if (option == 2)
            {

                app.WithdrawMoney();
                Console.WriteLine("Thank You For Visit  Bye .....");

            }

            }
            catch(BankException e)
            { 
                Console.WriteLine(e.Message);
            }
            catch(BankException e)
            {
                Console.WriteLine("some error occured")
            }
            if (option == 1)
            {
                app.Depositamount();
                Console.WriteLine("Thankyou For Visit Bye.....");

            }
            else if (option == 3)
            {
                app.Balance();
                Console.WriteLine("Your Amount Is Safe Bye.......");

            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
            Console.ReadLine();
        }
    }
}


