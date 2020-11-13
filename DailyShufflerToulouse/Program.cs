using System;

namespace DailyShufflerToulouse
{
    class Program
    {   
        static void Main(String[] args)
        {
            FlatFileStudentReader reader = new FlatFileStudentReader { FilePath = @".\Students.txt" };
            StudentShuffler shuffler = new StudentShuffler { Students = reader.Students };
            ConsoleOutput.DisplayStudents(shuffler.ShuffledStudents);
        }
    }
}
