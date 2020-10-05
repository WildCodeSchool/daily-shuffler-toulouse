using System;

namespace DailyShufflerToulouse
{
    class Program
    {
        static void Main(String[] args)
        {
            String[] toulouseStudents =
                { "ANGLADE Emilie", "BAGES Sébastien", "BRULTET Sophie", "BUI Coline",
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
            // Pour i allant de 0 à students.taille - 1:
                // j = GenererEntierAleatoireEntre(0, i)
                // k = students[i]
                // students[i] = students[j]
                // students[j] = k
            return students;
        }
    }
}
