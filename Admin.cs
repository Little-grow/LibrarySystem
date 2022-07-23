using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{

    internal class Admin
    {
        readonly static List<User> users = new();
        public readonly static Dictionary<string, string> BorrowedBooks = new();

        

        public static void AddUser()
        {
            User user = new User();
            ++User.Count;
            Console.WriteLine("Enter the User name, Please");
              user.Name = Console.ReadLine();
            Console.WriteLine("Enter the User Id");
             user.Id = int.Parse(Console.ReadLine());
            users.Add(user);
        }

        public static void UesrBorrowBook()
        {
            Console.WriteLine("Please, Enter the user name");
            string userName = Console.ReadLine();
            bool foundedUser = false;
            bool foundedBook = false;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Name == userName)
                {
                    Console.WriteLine("Enter the book name");
                    string bookName = Console.ReadLine();

                    for (int j = 0; j < Books.Count; j++)
                    {
                        if (Books.books[j].Name == bookName)
                        {
                            if (Books.books[j].Quantity < 0)
                            {
                                Console.WriteLine("Sorry the book isn't avilable now");
                                return;
                            }
                            Console.WriteLine("The procees done!");
                            foundedBook = true;
                            BorrowedBooks.Add(userName, bookName);
                            -- Books.books[j].Quantity;
                            return;
                        }
                    }

                    if (!foundedBook)
                    {
                        Console.WriteLine("Sorry, we don't have copy of this book");
                        return;
                    }
                    
                    foundedUser = true;
                    return;
                }
            }

            if (!foundedUser)
                Console.WriteLine("User Not founded, but you can add him");

        }
        public static void UserReturnBook()
        {
            Console.WriteLine("please, Enter user name");
            string userName = Console.ReadLine();
            
            bool foundedUser = false;
            bool foundedBook = false;

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Name == userName)
                {
                    foundedUser = true;
                    Console.WriteLine("Enter the book name");
                    string bookName = Console.ReadLine();

                    for (int j = 0; j < BorrowedBooks.Count; j++)
                    {
                        if (BorrowedBooks[userName] == bookName)
                        {
                            Console.WriteLine("Done!");
                            for (int k = 0; k < Books.Count; k++)
                            {
                                if (Books.books[k].Name == bookName)
                                {
                                    ++Books.books[k].Quantity;
                                    break;
                                }
                            }
                            foundedBook = true;
                        }
                    }
                    if (!foundedBook)
                    {
                        Console.WriteLine("Can't find this book, maybe you have misspelled");
                        return;
                    }
                }
                if (!foundedUser)
                {
                    Console.WriteLine("Sorry, user not found, Maybe you have misspelld the user name");
                }
            }




        }

    }
}
    

