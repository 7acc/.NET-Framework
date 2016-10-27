using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] assemblyTypes = assembly.GetTypes();

            foreach (Type t in assemblyTypes)
            {
                Console.WriteLine("\n....................\n"+t.MemberType +"\n" + t.FullName +"\n" + t.ReflectedType + "\n....................\n");
            }
            Console.ReadKey();
            }
    }
    class DummyClass
    {

    }
}
