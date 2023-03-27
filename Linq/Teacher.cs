using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Linq
{
    public class Teacher
    {
        public Teacher() { }
        public Teacher(string TeacherName)
        {
            this.TeacherName = TeacherName;
        }
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int TeacherCount { get; set; }

    }
}
