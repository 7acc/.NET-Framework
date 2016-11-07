using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    internal class Program
    {
        public DataAccsess DA;

        private static void Main(string[] args)
        {
            Program pgrm = new Program();
            pgrm.DA = new DataAccsess();

            //pgrm.PopulateDb();

            pgrm.PrintAllStudentsWithoutInclude();
            pgrm.PrintAllStudentsWithInclude();       
            pgrm.PrintStudentWithExplicitLoading();
            Console.ReadKey();

        }


        public void PopulateDb()
        {
            //--------------------------------------------------

            var course1 = new Course
            {
                CourseName = "course 1",
                Credits = 1234

            };
            DA.AddNewCourse(course1);

            var enrollment1 = new Enrollment
            {
                EnrollmentName = "Enrollment 1",
                CourseID = course1.CourseID,
                Grade = "A+"
            };
            DA.AddNewEnrollment(enrollment1);

            var student1 = new Student
            {
                FirstName = "Jacc",
                LastName = "Liden",
                EnrollmentDate = DateTime.Now.AddDays(-7),
            };
            student1.Enrollments.Add(enrollment1);
            DA.AddNewStudent(student1);


            //--------------------------------------------------

            var course2 = new Course
            {
                CourseName = "course 2",
                Credits = 56789
            };
            DA.AddNewCourse(course2);

            var enrollment2 = new Enrollment
            {
                EnrollmentName = "Enrollment 2",
                CourseID = course2.CourseID,
                Grade = "A-"
            };
            DA.AddNewEnrollment(enrollment2);

            var student2 = new Student
            {
                FirstName = "Sture",
                LastName = "Thuren",
                EnrollmentDate = DateTime.Now.AddDays(-1)
            };
            student2.Enrollments.Add(enrollment2);
            DA.AddNewStudent(student2);
        }

        public void PrintAllStudentsWithoutInclude()
        {
            var list = DA.GetAllSudents();
            list.ForEach(x => Console.WriteLine($"ID: {x.StudentID}\n" +
                                                $"Name {x.FirstName + " " + x.LastName}" +
                                                $"Enrollments\n" +
                                                $"{x.Enrollments.Count}"));
        }

        public void PrintAllStudentsWithInclude()
        {
            List<Student> list;
            using (var ctx = new TheContext())
            {
                list = ctx.Students.Include("Enrollments").ToList();


            }
            foreach (Student x in list)
            {
                Console.WriteLine($"ID: {x.StudentID}\n" +
                                  $"Name {x.FirstName + " " + x.LastName}\n" +
                                  $"Enrollments\n");
                foreach (Enrollment enrollment in x.Enrollments)
                {
                    Console.WriteLine(enrollment.EnrollmentName);
                }
            }

        }

        public void PrintStudentWithExplicitLoading()
        {
            using (var ctx = new TheContext())
            {
                ctx.Configuration.LazyLoadingEnabled = false;

                Console.Write("Enter The Name Of The student: ");
                string nameSearch = Console.ReadLine();

                var FoundStudent = ctx.Students.Include("Enrollments").FirstOrDefault(x => x.FirstName.StartsWith(nameSearch));

                Console.WriteLine($"ID: {FoundStudent.StudentID}\n" +
                                  $"Name: {FoundStudent.FirstName + " " + FoundStudent.LastName}\n");
                Console.WriteLine("Enrollments:");

                foreach (var Enrollment in FoundStudent.Enrollments)
                {
                    Console.WriteLine($"EnrollmentName: {Enrollment.EnrollmentName}\n" +
                                      $"Grade: {Enrollment.Grade}");

                }

                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("---------------------Explicit Loading------------------------");

                (ctx.Entry(FoundStudent).Collection(x => x.Enrollments)).Load();

                Console.WriteLine($"ID: {FoundStudent.StudentID}\n" +
                                  $"Name: {FoundStudent.FirstName + " " + FoundStudent.LastName}\n");
                Console.WriteLine("Enrollments:");

                foreach (var Enrollment in FoundStudent.Enrollments)
                {
                    Console.WriteLine($"EnrollmentName: {Enrollment.EnrollmentName}\n" +
                                      $"Grade: {Enrollment.Grade}");

                }
            }



        }
    }
}
