using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1___4._2___Seperation_Of_Concerns
{
    class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public Departments Department { get; set; }

        public enum Departments
        {
            Finance = 1,
            Development = 2,
            Testing = 3,
            CodeScrapping = 4,
            Slacking = 5
        }

        public override string ToString()
        {
            return "-------------------------------------------\n"+ 
                $"Name: {FirstName +" " + LastName} ({ID})\n\nDepartment: {Department.ToString()}\nHireDate: {HireDate.ToShortDateString()}\n\n";
        }






    }
}
