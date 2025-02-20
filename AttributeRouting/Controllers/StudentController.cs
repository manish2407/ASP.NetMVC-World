using AttributeRouting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributeRouting.Controllers
{
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>()
        {
            new Student() { Id = 1, Name = "Pranaya" },
            new Student() { Id = 2, Name = "Priyanka" },
            new Student() { Id = 3, Name = "Anurag" },
            new Student() { Id = 4, Name = "Sambit" }
        };
        [HttpGet]
        public ActionResult GetAllStudents()
        {
            return View(students);
        }
        [HttpGet]
        public ActionResult GetStudentByID(int studentID)
        {
            Student studentDetails = students.FirstOrDefault(s => s.Id == studentID);
            return View(studentDetails);
        }
        [HttpGet]
        [Route("Student/{studentID}/courses")]
        public ActionResult GetStudentCourses(int studentID)
        {
            List<string> CourseList = new List<string>();
            if (studentID == 1)
                CourseList = new List<string>() { "ASP.NET", "C#.NET", "SQL Server" };
            else if (studentID == 2)
                CourseList = new List<string>() { "ASP.NET MVC", "C#.NET", "ADO.NET" };
            else if (studentID == 3)
                CourseList = new List<string>() { "ASP.NET WEB API", "C#.NET", "Entity Framework" };
            else
                CourseList = new List<string>() { "Bootstrap", "jQuery", "AngularJs" };
            ViewBag.CourseList = CourseList;
            return View();
        }
        //Overriding the route prefix attribute in the Attribute Routing
        //default Route prefixing
        //[Route("tech/teachers")]

        //using the override Route Prefixing
        [Route("~/tech/teachers")]
        public ActionResult GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher() { Id = 1, Name = "James" },
                new Teacher() { Id = 2, Name = "Patrik" },
                new Teacher() { Id = 3, Name = "Smith" }
            };
            return View(teachers);
        }
    }
}