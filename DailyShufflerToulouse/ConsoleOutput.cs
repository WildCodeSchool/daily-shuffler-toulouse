using System;
using System.Collections.Generic;
using System.Text;

namespace DailyShufflerToulouse
{
    class ConsoleOutput
    {
        public static void DisplayStudents(Student[] students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine("Press Enter Key to Continue");

                while (Console.ReadKey().Key != ConsoleKey.Enter)
                { /* Wait a press on "Enter" key */ }
            }
        }
    }
}
