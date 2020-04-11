using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Inherit_a_
{
    class Teacher : person
    {
        public Teacher(string person, int age, string teacherID, string subject):
            base (person , age)
        {
            TeacherID = teacherID;
            Subject = subject;
        }
        public string TeacherID { get; set; }
        public string Subject { get; set; }
    }
}
