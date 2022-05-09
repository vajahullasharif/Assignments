using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Books
    {
            public string Name;
            private int Book_Id { get; set; }

            public int Book_ID
            {
                get { return Book_Id; }
                set { Book_Id = value; }
            }
            public void Display()
            {
                Console.WriteLine("Book id is:{0}", Book_Id);
                Console.WriteLine("Book name is:{1}", Name);
            }


        }
        class StructEg1
        {
            static void Main()
            {
                Books b = new Books();
                b.Book_ID = 100;
                b.Name = "Suspicios Partner";
                b.Display();
                Console.ReadLine();
            }
        }
}
