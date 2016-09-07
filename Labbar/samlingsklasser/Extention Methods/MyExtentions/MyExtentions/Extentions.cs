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
    }
}
