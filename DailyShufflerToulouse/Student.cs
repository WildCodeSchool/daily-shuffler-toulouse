using System;
using System.Collections.Generic;
using System.Text;

namespace DailyShufflerToulouse
{
    class Student
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
