using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public static class Utils
    {
        private static List<Institution> institutions = new List<Institution>();
        private static List<Department> departments = new List<Department>();
        private static List<Course> courses = new List<Course>();

        public static List<Institution> SeedInstitutions()
        {
            institutions.Add(new Institution("Otago Polytechnic", "Otago", "New Zealand"));
            institutions.Add(new Institution("University of Auckland", "Auckland", "New Zealand"));
            institutions.Add(new Institution("Victoria University of Wellington", "Wellington", "New Zealand"));

            return institutions;
        }

        public static List<Department> SeedDepartments()
        {
            departments.Add(new Department(institutions[0], "Information Technology"));
            departments.Add(new Department(institutions[1], "Mechanical Engineering"));
            departments.Add(new Department(institutions[2], "Environmental Science"));

            return departments;
        }

        public static List<Course> SeedCourses()
        {
            courses.Add(new Course (departments[0], "IT101", "Introduction to Information Technology", "Learn the fundamentals of Information Technology", 3, 1000));
            courses.Add(new Course(departments[1], "ME201", "Introduction to Mechanical Engineering", "Learn the basics of Mechanical Engineering", 4, 1500));
            courses.Add(new Course(departments[2], "ES301", "Introduction to Environmental Science", "Study the basics of Environmental Science", 3, 1200));
            return courses;
        }
    }



}
