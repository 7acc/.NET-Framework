using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1___4._2___Seperation_Of_Concerns
{
    class Application
    {
        public List<Employee> Employees { get; set; }

        internal void Run()
        {
            PopulateList();
            Navigate();
        }

        private void PopulateList()
        {
            Employees = new List<Employee>();
            Employees.Add(new Employee
            {
                ID = 1,
                FirstName = "Jacc",
                LastName = "Liden",
                Department = Employee.Departments.Slacking,
                HireDate = new DateTime(2016, 09, 28)

            });
            Employees.Add(new Employee
            {
                ID = 2,
                FirstName = "Jesus",
                LastName = "Christ",
                Department = Employee.Departments.Development,
                HireDate = new DateTime(0001, 01, 01)
            });
            Employees.Add(new Employee
            {
                ID = 3,
                FirstName = "Ben",
                LastName = "Dover",
                Department = Employee.Departments.CodeScrapping,
                HireDate = new DateTime(1997, 07, 01)
            });
            Employees.Add(new Employee
            {
                ID = 4 ,
                FirstName = "Sture",
                LastName = "thuren",
                Department = Employee.Departments.Testing,
                HireDate = new DateTime(1999, 01, 01)
            });
            Employees.Add(new Employee
            {
                ID = 5,
                FirstName = "Alfonso",
                LastName = "Kiraly",
                Department = Employee.Departments.Finance,
                HireDate = new DateTime(1987, 11, 20)
            });
            Employees.Add(new Employee
            {
                ID = 6,
                FirstName = "Gingerbread",
                LastName = "Man",
                Department = Employee.Departments.Development,
                HireDate = new DateTime()
            });
            Employees.Add(new Employee
            {
                ID = 7,
                FirstName = "Curt",
                LastName = "Cobain",
                Department = Employee.Departments.Slacking,
                HireDate = new DateTime(1982,10, 14)
            });
            Employees.Add(new Employee
            {
                ID = 8,
                FirstName = "Gunilla",
                LastName = "Gorilla",
                Department = Employee.Departments.Testing,
                HireDate = new DateTime(1970, 04, 13)
            });
        }

        public void Navigate()
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Menu.PrintMenu();
                ConsoleKey input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        Employees.OrderedByLastName().PrintList();
                        break;
                    case ConsoleKey.D2:
                        Employees.OrderedByFirstName().PrintList();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Menu.DepartmentAlternatives();
                        var key = Console.ReadKey(true);
                        int number = int.Parse(key.KeyChar.ToString());

                        Employees.FromdeDepartment((Employee.Departments)number).PrintList();
                        break;
                    case ConsoleKey.D4:
                        string searchWord = Console.ReadLine();
                        Employees.Search(searchWord).PrintList();
                        break;
                    case ConsoleKey.D5:
                        Employees.NoobEmployees().PrintList();
                        break;
                    case ConsoleKey.Escape:
                        loop = false;
                        return;
                    default:
                        break;

                        
                }
                Console.ReadKey();            
            }
        }
    }
}
