using System;
using System.Collections.Generic;
using System.IO;

namespace DailyShufflerToulouse
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] listOfTheStudents = AcquisitionOfTheListOfStudents();
            string[] toulouseStudents = ShuffleStudents(listOfTheStudents);
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

        private static string[] AcquisitionOfTheListOfStudents()
        {
            string fileOfTheListOfTheStudents = @"./Students.txt";
            List<String> listOfStudents = new List<string>();

            if (!File.Exists(fileOfTheListOfTheStudents))
            {
                Console.WriteLine("Error : The file Student.txt doesn't exist !");
            }

            using (StreamReader ReadingOfTheFile = new StreamReader(fileOfTheListOfTheStudents))
            {

                while (ReadingOfTheFile.Peek() > -1)
                {
                    string lineRead = ReadingOfTheFile.ReadLine();
                    listOfStudents.Add(lineRead);
                }

                String[] listofStudentsToArray = listOfStudents.ToArray();

                return listofStudentsToArray;
            }
        }
    }
}
