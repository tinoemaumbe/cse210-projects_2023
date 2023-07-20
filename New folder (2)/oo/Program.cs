using System;
using System.Collections.Generic;

namespace Ashton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some sample courses, students, and teachers
            Course course1 = new Course("Math", 101, "MATH101", "Introduction to Math", 3);
            Course course2 = new Course("English", 102, "ENGL102", "Introduction to English", 3);
            Course course3 = new Course("History", 103, "HIST103", "Introduction to History", 3);

            List<Course> courses = new List<Course>() { course1, course2, course3 };

            // Create some sample students and teachers
            Student student1 = new Student("User", "123 Main St", "john.smith@example.com", 1001);
            Teacher teacher1 = new Teacher("Instructor", "456 Elm St", "jane.doe@example.com", 2002);

            List<Student> students = new List<Student>() { student1 };
            List<Teacher> teachers = new List<Teacher>() { teacher1 };

            // Create and start the menu
            Menu menu = new Menu(courses, students, teachers);
            menu.Start();

            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");

            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }


            // After the menu starts, you can call the StudentMenu() and TeacherMenu() methods:
            menu.StudentMenu(student1);
            menu.TeacherMenu(teacher1);
        }
    }
}