using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAdmin
{
    class Student
    {
        public string FirstName { get; set; }
        public int Grade { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $"{LastName} {FirstName}: {Grade}%";
        }
    }
}
