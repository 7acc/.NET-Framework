using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    class DataAccsess
    {

        public  List<Student> GetAllSudents()
        {
            using (TheContext ctx = new TheContext())
            {
                var list = ctx.Students.ToList();
                return list;
            }
        }

        public void AddNewCourse(Course course)
        {
            using (TheContext ctx = new TheContext())
            {
                ctx.Courses.Add(course);
                ctx.SaveChanges();
            }
        }

        public void AddNewEnrollment(Enrollment enrollment)
        {
            using (TheContext ctx = new TheContext())
            {
                ctx.Enrollments.Add(enrollment);
                ctx.SaveChanges();
            }
        }

        public void AddNewStudent(Student student)
        {
            using (TheContext ctx = new TheContext())
            {
                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
        }
    }
}
