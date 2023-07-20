// NAME: ASHTON MUPEREKI
//COURSE: CSE210-C#
//PROJECT NAME: STUDENT MANAGEMENT SYSTEM
using System;
namespace Ashton
{

public class Course
    {
        private string _courseName;
        private int _courseID;
        private string _courseCode;
        private string _courseDescription;
        private List<Student> _enrolledStudents;
        private Dictionary<Student, double> _grades;
        private List<Teacher> _teachers;
        private int _credits;

        public Course(string courseName, int courseID, string courseCode, string courseDescription, int credits)
        {
            _courseName = courseName;
            _courseID = courseID;
            _courseCode = courseCode;
            _courseDescription = courseDescription;
            _enrolledStudents = new List<Student>();
            _grades = new Dictionary<Student, double>();
            _teachers = new List<Teacher>();
            _credits = credits;
        }

        public string GetCourseName()
        {
            return _courseName;
        }

        public string GetCourseCode()
        {
            return _courseCode;
        }

        public int GetCourseID()
        {
            return _courseID;
        }

        public string GetCourseDescription()
        {
            return _courseDescription;
        }

        public int GetCredits()
        {
            return _credits;
        }

        public void Enroll(Student student)
        {
            _enrolledStudents.Add(student);
            _grades.Add(student, 0);
        }

        public void Drop(Student student)
        {
            _enrolledStudents.Remove(student);
            _grades.Remove(student);
        }

        public bool IsEnrolled(Student student)
        {
            return _enrolledStudents.Contains(student);
        }

        public void AddGrade(Student student, double grade)
        {
            _grades[student] = grade;
        }

        public double GetGrade(Student student)
        {
            if (!_grades.ContainsKey(student))
            {
                throw new ArgumentException("Student is not enrolled in this course.");
            }

            return _grades[student];
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
        public string CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }

        public string CourseCode
        {
            get { return _courseCode; }
            set { _courseCode = value; }
        }
    }
}