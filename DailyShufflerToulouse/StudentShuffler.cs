using System;
using System.Collections.Generic;
using System.Text;

namespace DailyShufflerToulouse
{
    class StudentShuffler
    {
        public Student[] Students { get; set; }
        public Student[] ShuffledStudents
        {
            get
            {
                Student[] shuffledStudents = new Student[Students.Length];
                Students.CopyTo(shuffledStudents, 0);
                for (int i = 0; i < shuffledStudents.Length; i++)
                {
                    Random random = new Random();
                    int j = random.Next(0, i);
                    Student k = shuffledStudents[i];
                    shuffledStudents[i] = shuffledStudents[j];
                    shuffledStudents[j] = k;
                }
                return shuffledStudents;
            }
        }
    }
}
