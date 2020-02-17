using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Grade
    {
        public Grade(int studentId, int courseId, string gradeVal)
        {
            StudentId = studentId;
            CourseId = courseId;
            GradeValue = gradeVal;
        }


        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string GradeValue { get; set; }
    }
}
