// NAME: ASHTON MUPEREKI
//COURSE: CSE210-C#
//PROJECT NAME: STUDENT MANAGEMENT SYSTEM
using System;
namespace Ashton
{
    public class Teacher : Person
    {
        private List<Course> _courses;

        public Teacher(string name, string address, string email, int id) : base(name, address, email, id)
        {
            _courses = new List<Course>();
        }
        public List<Course> GetCoursesTaught()
        {
            List<Course> coursesTaught = new List<Course>();

            foreach (Course course in _courses)
            {
                if (course.GetTeachers().Contains(this))
                {
                    coursesTaught.Add(course);
                }
            }

            return coursesTaught;
        }
        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            _courses.Remove(course);
        }

        public void EnrollStudent(Course course, Student student)
        {
            course.Enroll(student);
        }

        public void AddGrade(Course course, Student student, double grade)
        {
            course.AddGrade(student, grade);
        }

        public double CalculateGPA(Student student)
        {
            double totalGrade = 0;
            int totalCredits = 0;

            foreach (Course course in _courses)
            {
                if (course.IsEnrolled(student))
                {
                    double grade = course.GetGrade(student);
                    int credits = course.GetCredits();

                    totalGrade += grade * credits;
                    totalCredits += credits;
                }
            }

            if (totalCredits == 0)
            {
                return 0;
            }

            return totalGrade / totalCredits;
        }

        public override string SaveName()
        {
            // implementation to save the teacher's name to a database or file
            return "Name saved!";
        }

        public override void SaveId()
        {
            // implementation to save the teacher's id to a database or file
            Console.WriteLine("Teacher ID saved!");
        }
        public string GetName()
        {
            return base._name;
        }

        public int GetID()
        {
            return base._id;
        }
    }
}