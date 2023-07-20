// NAME: ASHTON MUPEREKI
//COURSE: CSE210-C#
//PROJECT NAME: STUDENT MANAGEMENT SYSTEM
using System;
namespace Ashton
{
    public class Student : Person
    {
        private List<Course> _courses;

        public Student(string name, string address, string email, int id) : base(name, address, email, id)
        {
            _courses = new List<Course>();
        }

        public void Enroll(Course course)
        {
            _courses.Add(course);
        }
        public void Drop(Course course)
        {
            _courses.Remove(course);
        }

        public List<Course> ViewCourses()
        {
            return _courses;
        }

        public override string SaveName()
        {
            // implementation to save the student's name to a database or file
            return "Name saved!";
        }

        public override void SaveId()
        {
            // implementation to save the student's id to a database or file
            Console.WriteLine("Student ID saved!");
        }
        public string GetName()
        {
            return base._name;
        }

        public int GetID()
        {
            return base._id;
        }
        public void GetCourses()
        {
            Console.WriteLine("Courses:");

        }
        public void AddCourse(string courseName, string courseCode)
        {
            
            Console.WriteLine("Course added successfully.");
        }

        public void DropCourse(string name, string code)
        {
            Course courseToRemove = null;

            foreach (Course course in _courses)
            {
                if (course.CourseName == name && course.CourseCode == code)
                {
                    courseToRemove = course;
                    break;
                }
            }

            if (courseToRemove != null)
            {
                _courses.Remove(courseToRemove);
                Console.WriteLine("Course dropped successfully.");
            }
            else
            {
                Console.WriteLine("Course not found.");
            }
        }

    }
}    