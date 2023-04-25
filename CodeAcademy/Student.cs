using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
        public double Point { get; set; }
        public bool isGraduated { get; set; }

        public Student(string name, string surname,string group,double point,bool isGraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            this.isGraduated = isGraduated;
        }
        
        public  string FullName()
        {
            return $"{Name} {Surname}";
        }
        public string Details()
        {
            return $"{FullName()} {Group} {Point} {(isGraduated?"Mezun olub":"Mezun olmayib")}";
        }
        public string PermissionForNextExam()
        {
            return Point>80?"Imtahana gire bilersen":"Imtahana gire bilmezsen";
        }
    }
}
