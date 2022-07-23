using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class Books
    {
       
        public static readonly List<Books> books = new();

        public int    ID        { get;  private set;}
        public int Quantity     { get;   set;}
        public string Name      { get;  private set;}

        public static int Count { get;  set; } = 0;

        public Books()
        {
            Console.WriteLine("Enter the book ID");
            ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Ente the book Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Quantity");
            Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Done");

            books.Add(this); 
            ++Count;
        }

        public static void SearchForBook(string prefix)
        {
            int counter = 0;
            string[] booksNames = new string[Count];
            for (int i = 0; i < Count; i++)
            {
                if (books[i].Name.StartsWith(prefix))
                {
                    booksNames[counter] = books[i].Name;
                    ++counter;
                }
            }
            if (counter != 0)
            {
                for (int i = 0; i < counter; i++)
                {
                    Console.WriteLine($"{booksNames[i]}");
                }
            }
            else Console.WriteLine("Nothing");
        }
        public static void ListBooks()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"Name: {books[i].Name}\t ID: {books[i].ID}\t Quantity: {books[i].Quantity}");
            }
        }
        public static void SortBooksByID()
        {
            for (int i = 0; i < books.Count; i++)
                books.Sort((x, y) => x.ID.CompareTo(y.ID));

            Console.WriteLine($"{books[0].Name}");
            for (int i = 1; i < books.Count; i++)
                Console.WriteLine($",\t{books[i].Name}");
        }
        public static void SortBooksByName()
        {
            for (int i = 0; i < books.Count; i++)
            {
                books.Sort((x, y) => x.Name.CompareTo(y.Name));
                //  books.Sort(delegate (Book x, Book y) { return x.Name.CompareTo(y.Name); });
            }

            Console.WriteLine($"{books[0].Name}");
            for (int i = 1; i < books.Count; i++)
                Console.WriteLine($",\t{books[i].Name}");
        }
    }
}
