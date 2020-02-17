using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Student
    {

        public Student(int id, string name)
        {
            StudentId = id;
            Name = name;
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
    }
}
