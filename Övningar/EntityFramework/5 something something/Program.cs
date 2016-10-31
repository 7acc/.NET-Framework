using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _5_something_something
{
    static class Program
    {
        public static List<Employee> Employees;
        public static void Main(string[] args)
        {
            Employees = CreateListWithEmployees();

            IEnumerable<Employee> query = from e in Employees
                                          where e.HireDate > new DateTime(2009, 01, 20)
                                          orderby e.Name
                                          select e;


            query.Print();
            //even if i add a new employee after the query has been created,
            //the new employee is still shown in the print of the query           
            Employees.Add(new Employee
            {
                ID = 5,
                Name = "Employe 5",
                Age = 25,
                HireDate = new DateTime(2016, 10, 31)
            });

            query.Print();

            Dostuff();

            //Console.WriteLine(DoSomeOtherStuff().ToString());

            Tryer.TryingStuff();
            Console.ReadKey();
        }

        public static List<Employee> CreateListWithEmployees()
        {
            var list = new List<Employee>();
            list.Add(new Employee
            {
                ID = 1,
                Name = "Employe 1",
                Age = 25,
                HireDate = new DateTime(2010, 10, 10)
            });
            list.Add(new Employee
            {
                ID = 2,
                Name = "Employe 2",
                Age = 43,
                HireDate = new DateTime(2009, 01, 11)
            });
            list.Add(new Employee
            {
                ID = 3,
                Name = "Employe 3",
                Age = 56,
                HireDate = new DateTime(2009, 12, 12)
            });
            list.Add(new Employee
            {
                ID = 4,
                Name = "Employe 4",
                Age = 31,
                HireDate = new DateTime(2007, 07, 11)
            });


            return list;
        }

        public static void Print(this IEnumerable<Employee> query)
        {
            foreach (var employee in query)
            {
                Console.WriteLine(employee.Name);
            }
            Console.WriteLine("......................................\n");
        }

        public static void Dostuff()
        {
            IEnumerable<string> query = from t in Assembly.GetExecutingAssembly().GetTypes()
                                        where t.IsPublic
                                        select t.FullName;
            foreach (var thing in query)
            {
                Console.WriteLine(thing);
            }

        }

        public static XDocument DoSomeOtherStuff()
        {

            IEnumerable<XElement> thingQuery = from p in Process.GetProcesses()
                                               orderby p.ProcessName ascending
                                               select new XElement("Process",
                                                   new XAttribute("Name", p.ProcessName),
                                                   new XAttribute("ProcessID", p.Id));


            var thing =
                new XDocument(
                    new XElement("Processes", thingQuery));

            return thing;
        }

    
    }
}
