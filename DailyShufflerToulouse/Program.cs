using System;

namespace DailyShufflerToulouse
{
    class Program
    {
        static void Main(String[] args)
        {
            String[] toulouseStudents =
                { "BAGES Sébastien", "BRULTET Sophie", "BUI Coline",
                  "DELSOL Emilie", "DESNOUES Fabien", "DUMAS Maïlys", "DURCY Colas", "ESPASA Coralie",
                  "GILLIOTTE Fabien", "IZARD Julien", "LY François", "MESTE Hervé",
                  "SAID OMAR Gabriel", "ZAPICO Adrien" };
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
            for (int i = 0; i < students.Length - 1; i++)
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