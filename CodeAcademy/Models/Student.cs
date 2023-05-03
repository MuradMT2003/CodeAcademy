using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    internal class Student
    {
        private static int _id = 0;
        public int Id
        {
            get
            {
                return _id;
            }
        }

        public Student()
        {
            _id++;
        }
    }
}
