using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibblan
{
    public class BokComparator : IComparer
    {
        public int Compare(object obj1, object obj2)
        {

            Bok bok1 = (Bok)obj1;
            Bok bok2 = (Bok)obj2;
            string bokString1 = bok1.titel + bok1.författare;        
            string bokString2 = bok2.titel + bok2.författare;

            return bokString1.CompareTo(bokString2);
         
        }
    }
}
