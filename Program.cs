using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Inherit_a_
{
    class Program
    {
        static void Main(string[] args)
        {
            person person = new person("carlota", 50);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("parsudi", 58, "123456", "pubg");
            teacher.GetNameAndAge();


            student student = new student("roma", 13, "1234567", "kelapamuda.id");
            student.GetNameAndAge();


            Console.ReadKey();



        }
    }
}
