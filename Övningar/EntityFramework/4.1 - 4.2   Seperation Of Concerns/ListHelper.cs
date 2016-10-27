using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1___4._2___Seperation_Of_Concerns
{
    static class ListHelper
    {
        public static List<Employee> OrderedByLastName(this List<Employee> list)
        {
            return list.OrderBy(x => x.LastName).ToList();
        }

        public static List<Employee> OrderedByFirstName(this List<Employee> list)
        {
            return list.OrderBy(x => x.FirstName).ToList();
        }

        public static List<Employee> FromdeDepartment(this List<Employee> list, Employee.Departments department)
        {
            return list.Where(x => x.Department.ToString() == department.ToString()).ToList();
        }
        public static List<Employee> Search(this List<Employee> list, string searchString)
        {

            List<Employee> resultList = new List<Employee>();

            resultList.AddRange(list.Where(x => x.FirstName.StartsWith(searchString)));
            resultList.AddRange(list.Where(x => x.LastName.StartsWith(searchString)));

            return resultList;

        }
        public static List<Employee> NoobEmployees(this List<Employee> list)
        {
            return list.Where(x => x.HireDate > DateTime.Now.AddDays(-365)).ToList();
        }
        public static void PrintList(this List<Employee> list)
        {
            list.ForEach(x => Console.WriteLine(x));
        }



    }
}
