using System;

namespace DailyShufflerToulouse
{
    class Program
    {
        static void Main(String[] args)
        {
            String[] toulouseStudents =
                { "BAGES Sébastien", "BRULTET Sophie", "BUI Coline",
                  "DELSOL Emilie", "DESNOUES Fabien", "DUMAS Maylis", "DURCY Colas", "ESPASA Coralie",
                  "GILLIOTTE Fabien", "IZARD Julien", "LY François", "MESTE Hervé",
                  "SAID OMAR Gabriel", "ZAPICO Adrien" };
            toulouseStudents = ShuffleStudents(toulouseStudents);
            foreach (String student in toulouseStudents)
            {
                Console.WriteLine(student);
            }           
        }

        static String[] ShuffleStudents(String[] students)
        {
              for (int i = 0; i < students.Length-1;i++)
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
