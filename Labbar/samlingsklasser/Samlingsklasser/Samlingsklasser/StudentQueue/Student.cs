using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlingsklasser
{
    class Student
    {
        public string name { get; set; }
        public int grade { get; set; }

        public Student(string Name, int Grade)
        {
            this.name = Name;
            this.grade = Grade;
        }
      
    }
}
