using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Course
    {
        public Course(int id, string name)
        {
            CourseId = id;
            CourseName = name;
        }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
