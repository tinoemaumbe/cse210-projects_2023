// NAME: ASHTON MUPEREKI
//COURSE: CSE210-C#
//PROJECT NAME: STUDENT MANAGEMENT SYSTEM
using System;
namespace Ashton
{
    public class Enrollment
    {
        private Course _course;
        private Student _student;
        private DateTime _enrollmentDate;

        public Enrollment(Course course, Student student, DateTime enrollmentDate)
        {
            _course = course;
            _student = student;
            _enrollmentDate = enrollmentDate;
        }

        public Course GetCourse()
        {
            return _course;
        }

        public Student GetStudent()
        {
            return _student;
        }

        public DateTime GetEnrollmentDate()
        {
            return _enrollmentDate;
        }
    }
}