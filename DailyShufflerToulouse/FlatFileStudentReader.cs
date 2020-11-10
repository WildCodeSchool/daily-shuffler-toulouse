using System;
using System.Collections.Generic;
using System.IO;

namespace DailyShufflerToulouse
{
    class FlatFileStudentReader
    {
        public String FilePath { get; set; }
        public Student[] Students
        {
            get
            {
                List<Student> students = new List<Student>();

                using (StreamReader fileStream = new StreamReader(FilePath))
                {
                    while (fileStream.Peek() > -1)
                    {
                        String[] line = fileStream.ReadLine().Split(' ');
                        Student newStudent = new Student { FirstName = line[1], LastName = line[0] };
                        students.Add(newStudent);
                    }

                    return students.ToArray();
                }
            }
        }   
    }
}
