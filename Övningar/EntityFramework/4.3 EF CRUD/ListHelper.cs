using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3_EF_CRUD
{
    internal static class ListHelper
    {
        public static List<Authors> OrderedByLastName(this List<Authors> list)
        {
            return list.OrderBy(x => x.LastName).ToList();
        }

        public static List<Authors> OrderedByFirstName(this List<Authors> list)
        {
            return list.OrderBy(x => x.FirstName).ToList();
        }

        public static List<Authors> Search(this List<Authors> list, string searchString)
        {

            List<Authors> resultList = new List<Authors>();

            resultList.AddRange(list.Where(x => x.FirstName.StartsWith(searchString)));
            resultList.AddRange(list.Where(x => x.LastName.StartsWith(searchString)));

            return resultList;
        }

        public static Authors GetAuthorByID(this List<Authors> list, int Id)
        {
            return list.FirstOrDefault(x => x.AuthorID == Id);
        }

        public static void PrintList(this List<Authors> list)
        {
            list.ForEach(Console.WriteLine);
        }
    }
}
