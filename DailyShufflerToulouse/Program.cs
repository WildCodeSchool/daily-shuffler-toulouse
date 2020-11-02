using System;

namespace DailyShufflerToulouse
{
    class Program
    {
        static void Main(String[] args)
        {
            String[] toulouseStudents = System.IO.File.ReadAllLines(@".\Students.txt"); // IMPORTANT ! : Please note one name per line
            toulouseStudents = ShuffleStudents(toulouseStudents);
            DisplayStudents(toulouseStudents);
        }

        static void DisplayStudents(String[] students)
        {
            foreach (String student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine("Press Enter Key to Continue");

                while (Console.ReadKey().Key != ConsoleKey.Enter)
                { /* Wait a press on "Enter" key */ }
            }
        }

        static String[] ShuffleStudents(String[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Random random = new Random();
                int j = random.Next(0, i);
                string k = students[i];
                students[i] = students[j];
                students[j] = k;
            }
            return students;
        }
    }
}
