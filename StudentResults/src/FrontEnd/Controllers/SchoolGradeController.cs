using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class SchoolGradeController : Controller
    {
        DataAccessor context = new DataAccessor();

        [HttpGet("get-school-grades")]
        public IActionResult GetSchoolGrades()
        {
            List<Grade> grades = context.GetGrades();
            return new OkObjectResult(grades);
        }

        [HttpGet("get-courses")]
        public IActionResult GetCourses()
        {           
            List<Course> courses = context.GetCourses();
            return new OkObjectResult(courses);
        }

        [HttpGet("get-students")]
        public IActionResult GetStudents()
        {
            List<Student> students = context.GetStudents();
            return new OkObjectResult(students);
        }
    }
}
