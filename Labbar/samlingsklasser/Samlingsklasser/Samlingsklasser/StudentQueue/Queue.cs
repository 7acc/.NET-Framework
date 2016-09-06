using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlingsklasser
{
    class Queue
    {
        public static Queue<Student> studentQueue;

        public static void Run()
        {
            studentQueue = new Queue<Student>();
            studentQueue.Enqueue(new Student("Tom Sawyer", 9));
            studentQueue.Enqueue(new Student("Hucleberry Fin", 6));
            studentQueue.Enqueue(new Student("Elton John", 0));

            while (studentQueue.Count > 0)
            {
                Congratulate(studentQueue.Dequeue()); 
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

