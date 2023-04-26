using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy
{
    internal class Group
    {
        public int No { get; set; }
        public int Limit { get; set; }
        private Student[] Students { get; set; }
        public Group(int no,int limit)
        {
            No = no;
            Limit = limit;
            Students = new Student[Limit];
        }
        public void AddStudent(Student student)
        {
            int helper = 0;
            if (Limit > helper)
            {
                Students[helper] = student;
                helper++;
            }
        }
        public void GetStudents()
        {
            foreach(Student student in Students)
            {
                if(student != null)
                {
                    Console.WriteLine(student.Name + " " + student.Surname);
                }
                
            }
        }
    }
}
