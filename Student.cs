using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Inherit_a_
{
    class student : person
    {
        public student(string person, int age, string StudentID, string email) :
            base(person, age)
        {
            StudentID = StudentID;
            Email = email;
            
            
        }

        public string StudentID { get; set; }
        public string Email { get; set; }
    }
}