using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryUser
    {
        public LibraryUser(string name, string surname, int id)
        {
            Name = name;
            Surname = surname;
            ID = id;
        }
        public string Name { get; }
        public string Surname { get; }
        public int ID { get; }

        
        string[] books = new string[3];

        public void AddBook()
        {
            int result = BooksCount();
            if (result >= 3) Console.WriteLine("You cant get more book, you greedy bastard");
            if (result < 3)
            {
                Console.WriteLine("Enter book name");
                for (int i = 0; i < 3; i++)
                {
                    if (books[i] == null) books[i]=Console.ReadLine();
                }
            }            
        }

        public void AddBook(string bookname)
        {
            int result = BooksCount();            
            if (result < 3)
            {                
                for (int i = 0; i < 3; i++)
                {
                    if (books[i] == null)  {books[i] = bookname; break;}
                }
            }
        }

        public void RemoveBook()
        {
            Console.WriteLine("Enter book name");
            string result = Console.ReadLine();
            bool checker = false;
            for (int i = 0; i < 3; i++)
            {
                if (books[i] == result)
                {
                    Console.WriteLine("{0} Succesfully removed", books[i]);
                    books[i] = null;
                    checker = true; 
                }
            }
            if (checker == false) Console.WriteLine("Something went wrong. Check the book name.");

        }

        public void BookInfo()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(books[i]);
            }

        }

        public int BooksCount()
        {
            int counter = 0;
            for (int i = 0; i < 3; i++)
            {
                if (books[i] != null) counter++;
            }
            return counter;
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            LibraryUser vasya = new LibraryUser("Vasya","Nalivaiko",1);
            LibraryUser petya = new LibraryUser("Petya","Hudoi", 2);

            vasya.AddBook("Two Towers");
            vasya.AddBook("Harry Potter");

            petya.AddBook("Math");

            vasya.BookInfo();
            petya.BookInfo();

            vasya.RemoveBook();
            Console.WriteLine(petya.BooksCount());

            Console.ReadKey();
        }
    }
}
