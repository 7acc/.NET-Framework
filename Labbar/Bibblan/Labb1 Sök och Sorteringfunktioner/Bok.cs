using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibblan
{

    public class Bok : IComparable
    {
        public string ISBN { get; set; }
        public string titel { get; set; }
        public string författare { get; set; }
        public int pris { get; set; }

        public Bok()
        {

        }
        public Bok (string isbn, string titel, string författare, int pris)
        {
            this.ISBN = isbn;
            this.titel = titel;
            this.författare = författare;
            this.pris = pris;
        }

        public void SkrivUt()
        {
            Console.WriteLine("ISBN: {0}\n Titel: {1}\n Författare: {2}{3}", ISBN, titel, författare, pris);
        }

        public int PrisVidAntal(int antal)
        {
            return this.pris * antal;
        }

        public int CompareTo(object obj)
        {
            Bok b = (Bok)obj;
            return this.ISBN.CompareTo(b.ISBN);
        }
                
        public override int GetHashCode()
        {         
            return ISBN.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Bok b = (Bok)obj;
            return this.ISBN.Equals(b.ISBN);
        }
    }
}
