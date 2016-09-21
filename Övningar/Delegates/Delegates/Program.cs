using System;
using System.Collections.Generic;
using System.Collections;

namespace Delegates
{
    public delegate void ProcesBookDelegate(Book book);
    public struct Book
    {
        public string Title;
        public string Author;
        public decimal Price;
        public bool Paperback;

        public Book(string title, string author, decimal price, bool paperback)
        {
            Title = title;
            Author = author;
            Price = price;
            Paperback = paperback;
        }
    }
    public class BookDB
    {

        ArrayList bookList = new ArrayList();
        public void AddBook(string title, string author, decimal price, bool paperback)
        {
            bookList.Add(new Book(title, author, price, paperback));
        }
        public void ProcessPaperBackBook(ProcesBookDelegate PBDelegate)
        {
            foreach (Book book in bookList)
            {
                if (book.Paperback)
                {
                    PBDelegate(book);
                }

            }
        }
    }

    namespace bookTestClient
    {
        using Delegates;

        class PriceTotaller
        {
            int countBooks = 0;
            decimal priceBooks = 0.0M;

            internal void AdBookTotal(Book Book)
            {
                countBooks += 1;
                priceBooks += Book.Price;
            }

            internal decimal AveragePrice()
            {
                return priceBooks / countBooks;
            }
        }
        class Test
        {
            static void PrintTitle(Book b)
            {
                Console.WriteLine("      {0}", b.Title);
            }
            static void Main()
            {
                BookDB bookDb = new BookDB();
                AddBooks(bookDb);

                Console.WriteLine("paperbackbooks");
                bookDb.ProcessPaperBackBook(new ProcesBookDelegate(PrintTitle));

                PriceTotaller totaller = new PriceTotaller();
                bookDb.ProcessPaperBackBook(new ProcesBookDelegate(totaller.AdBookTotal));
                Console.WriteLine("Average paperback book price: ${0:#.##}", totaller.AveragePrice());
                Console.ReadKey();
            }

            static void AddBooks(BookDB bookDb)
            {
                bookDb.AddBook("The story of Kevin, The SpaceMan", "kevin", 19.95M, true);
                bookDb.AddBook("Jesus Crist, its hughe", "thats what she said", 39.95M, true);
                bookDb.AddBook("44 magnum", "C.Eastwood", 129.95M, false);
                bookDb.AddBook("It tied the room together", "The Dude", 12.00M, true);






            }
        }
    }   
}
