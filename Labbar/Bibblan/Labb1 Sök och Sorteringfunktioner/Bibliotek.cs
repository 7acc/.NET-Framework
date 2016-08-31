using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibblan
{
    public class Bibliotek : BokComparator
    {
        static ArrayList bokList { get; set; }
        static Hashtable bokHash { get; set; }
        private string menu = "[1]Ny bok \n" +
                           "[2]Lista Böcker (arraylist) \n" +
                           "[3]Sök bok (arraylist) \n" +
                           "[4]Sortera efter ISBN \n" +
                           "[5]Sortera efter författare/titel \n" +
                           "[6]Lista böcker(hashtable) \n" +
                           "[7]Sök bok(hashtable) \n" +
                           "[Q]Exit \n";

        public Bibliotek()
        {
            bokList = new ArrayList();
            bokHash = new Hashtable();
        }
        public void Meny()
        {
            bool loop = true;
            while (loop == true)
            {
             
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(menu);

                ConsoleKeyInfo keyn = Console.ReadKey(true);
                switch (keyn.KeyChar.ToString().ToUpper())
                {
                    case "1": // ny bok

                        NyBok();
                        break;
                    case "2": // Lista böcker (arraylist)
                        ListaList();
                        break;
                    case "3": // sök bok (arraylist)
                        Console.Write("ISBN: ");
                        string isbn = Console.ReadLine();
                        var bok = SökList(isbn);
                        bok.SkrivUt();                    
                        break;
                    case "4": // sortera böcker efter ISBN
                        SortListISBN();
                        Console.WriteLine("listan har sorterats!!");
                        break;
                    case "5": // sortera böcker efter Författare titel
                        SortListNamn();
                        Console.WriteLine("listan har sorterats!!");
                        break;
                    case "6": // Lista böcker (hashtable)
                        ListaHash();
                        break;
                    case "7": // sök bok (hashtable)
                        Console.Write("ISBN: ");
                        string isbnHash = Console.ReadLine();
                        Bok bokHash = SökHash(isbnHash);
                        bokHash.SkrivUt();

                        break;
                    case "Q": // avsluta
                        Console.WriteLine("BYE BYE");
                        Console.ReadKey();
                        return;
                    default:
                        break;

                }
            }

        }
        static void NyBok()
        {
            Console.Write("ISBN: ");
            string i = Console.ReadLine();
            Console.Write("Titel: ");
            string t = Console.ReadLine();
            Console.Write("Författare: ");
            string f = Console.ReadLine();
            Console.Write("Pris: ");
            int p = int.Parse(Console.ReadLine());

            Bok book = new Bok(i, t, f, p);

            bokList.Add(book);
            bokHash.Add(book.ISBN, book);
        }
        static void ListaList()
        {
            foreach (Bok b in bokList)
            {
                b.SkrivUt();

            }
        }

        static void ListaHash()
        {
            ICollection collection = bokHash.Values;

            foreach (Bok b in collection)
            {
                b.SkrivUt();
            }
        }
        static Bok SökList(string isbn)
        {
            
            Bok boken = null;
            foreach (Bok b in bokList)
            {
               
                if (b.ISBN == isbn)
                {
                    boken = b;
                }             
            }

            return boken;
            //var bok = new Bok();
            //bok.ISBN = isbn;

            //return bokList.Cast<Bok>().Where(obj => obj.Equals(bok)).Cast<Bok>().FirstOrDefault();
        }

        static Bok SökHash(string ISBN)
        {
            return (Bok)bokHash[ISBN];

        }

        static void SortListISBN()
        {
            bokList.Sort();
        }

        static void SortListNamn()
        {          
            bokList.Sort(new BokComparator());
        }

        public void Main()
        {
            Bok book1 = new Bok("1234", "jacc", "liden", 10);
            Bok book2 = new Bok("4321", "sture", "thuren", 99);
            Bok book3 = new Bok("999", "jesus", "krstus", 10000);
            Bok book4 = new Bok("1111", "höken", "löken", 0);

            bokList.Add(book1);
            bokList.Add(book2);
            bokList.Add(book3);
            bokList.Add(book4);

            bokHash.Add(book1.ISBN, book1);
            bokHash.Add(book2.ISBN, book2);

            bokHash.Add(book3.ISBN, book3);

            bokHash.Add(book4.ISBN, book4);
            Meny();
           


        }
    }
}
