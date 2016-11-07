using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    class Student
    {


        public Student()
        {
            this.Enrollments = new HashSet<Enrollment>();
        }
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
       
      
    }
}
