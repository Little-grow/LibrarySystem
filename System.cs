using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class System
    {
        static void UI()
        {
            Console.WriteLine("\t\t******************************");
            Console.WriteLine("\t\t\tLibrarySystem");
            Console.WriteLine("1) Add a book");
            Console.WriteLine("2) Search for A book");
            Console.WriteLine("3) List all the Books");
            Console.WriteLine("4) Sort books by ID");
            Console.WriteLine("5) Sort books by name");
            Console.WriteLine("6) Add new user");
            Console.WriteLine("7) User borrow book");
            Console.WriteLine("8) User return book");
            Console.WriteLine("9) Exit");
        }

       public static void AdminChoices()
        {
            int choice = -1;
            while (choice == -1)
            {
                UI();
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1) { Books book = new(); }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the Prefix, Please");
                    string prfix = Console.ReadLine();
                    Books.SearchForBook(prfix);
                }
                else if (choice == 3)
                    Books.ListBooks();
                else if (choice == 4)
                    Books.SortBooksByID();
                else if (choice == 5)
                    Books.SortBooksByName();
                else if (choice == 6)
                    Admin.AddUser();
                else if (choice == 7)
                    Admin.UesrBorrowBook();
                else if (choice == 8)
                    Admin.UserReturnBook();
                else if (choice == 9)
                {
                    Console.WriteLine("Have a nice day");
                    break;
                }
                    
                choice = -1;
            }
        }
    }
}
