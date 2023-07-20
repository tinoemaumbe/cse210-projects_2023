// NAME: ASHTON MUPEREKI
//COURSE: CSE210-C#
//PROJECT NAME: STUDENT MANAGEMENT SYSTEM
using System;
namespace Ashton
{
    public class Department
    {
        private string _name;
        private List<Course> _courses;
        private List<Teacher> _teachers;

        public Department(string name)
        {
            _name = name;
            _courses = new List<Course>();
            _teachers = new List<Teacher>();
        }

        public string GetName()
        {
            return _name;
        }

        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            _courses.Remove(course);
        }

        public List<Course> GetCourses()
        {
            return _courses;
        }

        public void AddTeacher(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            _teachers.Remove(teacher);
        }

        public List<Teacher> GetTeachers()
        {
            return _teachers;
        }
    }
}