using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlingsklasser
{
    class Queue
    {
        public static Queue<Student> StudentQueue;

        public static void Run()
        {
            StudentQueue = new Queue<Student>();
            StudentQueue.Enqueue(new Student("Tom Sawyer", 9));
            StudentQueue.Enqueue(new Student("Hucleberry Fin", 6));
            StudentQueue.Enqueue(new Student("Elton John", 0));

            while (StudentQueue.Count > 0)
            {
                Congratulate(StudentQueue.Dequeue()); 
            }           
            Console.ReadKey();         
        } 

        public static void Congratulate(Student student)
        {
            if (student.grade > 0)
            {
                Console.WriteLine("congratulations {0}!!,you passed the course with the grade: {1}", student.name, student.grade.ToString());
            }
            else
            {
                Console.WriteLine("Sorry {0}, but you failed the course", student.name);
            }

        }
    }
}

