using Student_Details_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_Details_API.Helper
{
    public static class ApiHelper
    {
        public static MainModelStudentData PopulateObject()
        {
            var dto = new MainModelStudentData();
            var students1 = new Students
            {
                Name = "Alice",
                Age = "20",
                Hobbies = new string[] { "reading", "swimming", "coding" }
            };

            var students2 = new Students
            {
                Name = "Bob",
                Age = "22",
                Hobbies = new string[] { "painting", "dancing", "singing" }
            };
            dto.Students = new List<Students>();

            dto.Students.Add(students1);
            dto.Students.Add(students2);

            return dto;
        }
    }
}