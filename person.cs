using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Inherit_a_
{
    class person
    {

        string Name;
        int Age;

        public person (string person, int age)
        {
            Name = person;
            Age = age;
        }

     
        public void GetNameAndAge()
        {
            Console.WriteLine("the person has name : {0}", Name);
            Console.WriteLine("the person has age   : {0}", Age);
        }
    }
}
