// NAME: ASHTON MUPEREKI
//COURSE: CSE210-C#
//PROJECT NAME: STUDENT MANAGEMENT SYSTEM
using System;
namespace Ashton
{
    public class Grade
    {
        private Course _course;
        private Student _student;
        private double _value;

        public Grade(Course course, Student student, double value)
        {
            _course = course;
            _student = student;
            _value = value;
        }

        public Course GetCourse()
        {
            return _course;
        }

        public Student GetStudent()
        {
            return _student;
        }

        public double GetValue()
        {
            return _value;
        }
    }
}