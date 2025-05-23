﻿using AttributeRouting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributeRouting.Controllers
{
    [RoutePrefix("students")]
    public class studentsController : Controller
    {
        //1. Using Separate Routes for every Action Result

        //static List<Student> students = new List<Student>()
        //{
        //    new Student() { Id = 1, Name = "Pranaya" },
        //    new Student() { Id = 2, Name = "Priyanka" },
        //    new Student() { Id = 3, Name = "Anurag" },
        //    new Student() { Id = 4, Name = "Sambit" }
        //};
        //[HttpGet]
        //[Route("students")]
        //public ActionResult GetAllStudents()
        //{
        //    return View(students);
        //}
        //[HttpGet]
        //[Route("students/{studentID}")]
        //public ActionResult GetStudentByID(int studentID)
        //{
        //    Student studentDetails = students.FirstOrDefault(s => s.Id == studentID);
        //    return View(studentDetails);
        //}
        //[HttpGet]
        //[Route("students/{studentID}/courses")]
        //public ActionResult GetStudentCourses(int studentID)
        //{
        //    List<string> CourseList = new List<string>();
        //    if (studentID == 1)
        //        CourseList = new List<string>() { "ASP.NET", "C#.NET", "SQL Server" };
        //    else if (studentID == 2)
        //        CourseList = new List<string>() { "ASP.NET MVC", "C#.NET", "ADO.NET" };
        //    else if (studentID == 3)
        //        CourseList = new List<string>() { "ASP.NET WEB API", "C#.NET", "Entity Framework" };
        //    else
        //        CourseList = new List<string>() { "Bootstrap", "jQuery", "AngularJs" };
        //    ViewBag.CourseList = CourseList;
        //    return View();
        //}

        //2. using Common Route Attribute at the Controller Level
        //static List<Student> students = new List<Student>()
        //{
        //    new Student() { Id = 1, Name = "Pranaya" },
        //    new Student() { Id = 2, Name = "Priyanka" },
        //    new Student() { Id = 3, Name = "Anurag" },
        //    new Student() { Id = 4, Name = "Sambit" }
        //};
        //[HttpGet]
        //[Route]
        ////This will be translated to /students 
        //public ActionResult GetAllStudents()
        //{
        //    return View(students);
        //}
        //[HttpGet]
        //[Route("{studentID}")]
        ////This will be translated to /students/2
        //public ActionResult GetStudentByID(int studentID)
        //{
        //    Student studentDetails = students.FirstOrDefault(s => s.Id == studentID);
        //    return View(studentDetails);
        //}
        //[HttpGet]
        //[Route("{studentID}/courses")]
        ////This will be translated to /students/2/course
        //public ActionResult GetStudentCourses(int studentID)
        //{
        //    List<string> CourseList = new List<string>();
        //    if (studentID == 1)
        //        CourseList = new List<string>() { "ASP.NET", "C#.NET", "SQL Server" };
        //    else if (studentID == 2)
        //        CourseList = new List<string>() { "ASP.NET MVC", "C#.NET", "ADO.NET" };
        //    else if (studentID == 3)
        //        CourseList = new List<string>() { "ASP.NET WEB API", "C#.NET", "Entity Framework" };
        //    else
        //        CourseList = new List<string>() { "Bootstrap", "jQuery", "AngularJs" };
        //    ViewBag.CourseList = CourseList;
        //    return View();
        //}

        //4. Using Route COnstraints Concept in Attribute Routing
        static List<Student> students = new List<Student>()
        {
            new Student() { Id = 1, Name = "Pranaya" },
            new Student() { Id = 2, Name = "Priyanka" },
            new Student() { Id = 3, Name = "Anurag" },
            new Student() { Id = 4, Name = "Sambit" }
        };

        [HttpGet]
        [Route("{studentID:int}")] //Adding Route Constraint for int parameter 
        public ActionResult GetStudentDetails(int studentID)
        {
            Student studentDetails = students.FirstOrDefault(s => s.Id == studentID);
            return View(studentDetails);
        }

        [HttpGet]
        [Route("{studentName:alpha}")] //Adding Route Constraint for string parameter 
        public ActionResult GetStudentDetails(string studentName)
        {
            Student studentDetails = students.FirstOrDefault(s => s.Name == studentName);
            return View(studentDetails);
        }
    }
}