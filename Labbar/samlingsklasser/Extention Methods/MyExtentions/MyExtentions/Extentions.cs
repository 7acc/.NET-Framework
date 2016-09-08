using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtentions
{
   static class Extentions
    {

        public static Person FindPersonInList(this List<Person> list, string name)
        {
            Person found = list.Find(x => x.FirstName == name);
            return found;           
        }
        public static void NewAdress(this Person P, string newAdress)
        {
            P.Adress = newAdress;
        }
        public static void NewLastName(this Person P, string newLastname)
        {
            P.LastName = newLastname;
        }
    }
}
