using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1___4._2___Seperation_Of_Concerns
{
    static class Menu
    {
        static string MainMenu =
            @"(1) Show Ordered By LastName                            
(2) Show Ordered By FirstName
(3) Show From Department
(4) Search
(5) Show Noobs
-------------------------------------------------
";      
          
        public static void PrintMenu()
        {
            Console.WriteLine(MainMenu);
        }
        public static void DepartmentAlternatives()
        {        
            int i = 1;
            Console.WriteLine("Choose Department!\n");
            foreach (var item in Enum.GetValues(typeof(Employee.Departments)))
            {
                Console.WriteLine($"{i} - {item}");
                i++;
            }           
        }       
    }
}
