// NAME: ASHTON MUPEREKI
//COURSE: CSE210-C#
//PROJECT NAME: STUDENT MANAGEMENT SYSTEM
using System;
namespace Ashton
{
    public class Menu
    {
        private List<Course> _courses;
        private List<Student> _students;
        private List<Teacher> _teachers;


        public Menu(List<Course> courses, List<Student> students, List<Teacher> teachers)
        {
            _courses = courses;
            _students = students;
            _teachers = teachers;
        }

        public void Start()
        {
            Console.WriteLine("Welcome to the School Management System!");

            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. 'ENTER 1' to login as a student and after that 'ENTER 3' to proceed to  menu");
                Console.WriteLine("2. 'ENTER 2' to login as a teacher and after that 'ENTER 3' to proceed to  menu");
                
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        StudentLogin();
                        break;
                    case "2":
                        TeacherLogin();
                        break;
                    case "3":
                        Console.WriteLine("************************************************");
                        return;
                    case "4":
                        Console.WriteLine("************************************************");
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        public void StudentLogin()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your ID (6 digits):");
            string idString = Console.ReadLine();

            // TODO: Validate the ID and find the corresponding student object
            
            // Validate the ID
            if (idString.Length != 6 || !int.TryParse(idString, out int id))
            {
                Console.WriteLine("Invalid ID, please enter a 6-digit number.");
                return;
            }

            // TODO: Implement student functionality

            }
            public void StudentMenu(Student student)
            {
            Console.WriteLine($"Welcome {student.GetName()}!");

            while (true)
            {
                Console.WriteLine(" OPTIONS 1 TO 3 ARE FOR STUDENTS AND OPTION 4 IS FOR TEACHERS");
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

                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. View courses");
                Console.WriteLine("2. Add course");
                Console.WriteLine("3. Drop course");
                Console.WriteLine("4. ENTER 4 IF YOU`RE A TEACHER TO PROCEED TO TEACHER MENU");
                

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // TODO: Implement view courses
                        ViewCourses(student);
                        break;
                    case "2":
                        // TODO: Implement add course
                        Console.Write("Enter course name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter course code: ");
                        string code = Console.ReadLine();

                        student.AddCourse(name, code);
                        
                        break;
                    case "3":
                        // TODO: Implement drop course

                        Console.Write("Enter course name: ");
                        string coursename = Console.ReadLine();

                        Console.Write("Enter course code: ");
                        string coursecode = Console.ReadLine();

                        student.DropCourse(coursename, coursecode);
                        break;
                    case "4":
                        Console.WriteLine("Logging out...");
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
        public void ViewCourses(Student student)
        {
            Console.WriteLine("Courses:  Math For Real World","Web Development","JavaScript","From Atoms To Humans","Carrier Development","Accounting Basics","Business Management");

            Console.WriteLine("Press Enter to return to the menu...");
            Console.ReadLine();
        }


        public void TeacherLogin()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your ID (6 digits):");
            string idString = Console.ReadLine();

            // TODO: Validate the ID and find the corresponding teacher object
            if (idString.Length != 6 || !int.TryParse(idString, out int id))
            {
                Console.WriteLine("Invalid ID, please enter a 6-digit number.");
                return;
            }

        }
        
        public void TeacherMenu(Teacher teacher)
    {
        Console.WriteLine($"Welcome {teacher.GetName()}!");

        while (true)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. View courses taught");
            Console.WriteLine("2. Add course");
            Console.WriteLine("3. Remove course");
            Console.WriteLine("4. Enroll student into a course");
            Console.WriteLine("5. Logout");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    // TODO: Implement view courses taught
                    List<Course> coursesTaught = teacher.GetCoursesTaught();
                    Console.WriteLine("Courses taught:   JavaScript","Web Development");

                    foreach (Course course in coursesTaught)
                    {
                        Console.WriteLine("{0} ({1})", course.GetCourseName(), course.GetCourseCode());
                    }
                    break;
                case "2":
                            // Add course
                    Console.WriteLine("Enter course name:");
                    string courseName = Console.ReadLine();

                    Console.WriteLine("Enter course code:");
                    string courseCode = Console.ReadLine();

                    Console.WriteLine("Enter course description:");
                    string courseDescription = Console.ReadLine();

                    Console.WriteLine("Enter course credits:");
                    int credits = int.Parse(Console.ReadLine());

                    Course newCourse = new Course(courseName, 0, courseCode, courseDescription, credits);
                    teacher.AddCourse(newCourse);

                    Console.WriteLine("Course added.");
                    break;
                case "3":
                    // Remove course
                    List<Course> coursesToRemove = teacher.GetCoursesTaught();
                    Console.WriteLine("Select a course to remove:");

                    for (int i = 0; i < coursesToRemove.Count; i++)
                    {
                        Console.WriteLine("{0}. {1} ({2})", i + 1, coursesToRemove[i].GetCourseName(), coursesToRemove[i].GetCourseCode());
                    }

                    int courseToRemoveIndex = int.Parse(Console.ReadLine()) - 1;

                    if (courseToRemoveIndex >= 0 && courseToRemoveIndex < coursesToRemove.Count)
                    {
                        Course courseToRemove = coursesToRemove[courseToRemoveIndex];
                        teacher.RemoveCourse(courseToRemove);
                        Console.WriteLine("Course removed.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid course selection.");
                    }
                    break;
                case "4":
                    // Enroll student
                    List<Course> coursesToEnroll = teacher.GetCoursesTaught();
                    Console.WriteLine("Select a course to enroll the student in:");

                    for (int i = 0; i < coursesToEnroll.Count; i++)
                    {
                        Console.WriteLine("{0}. {1} ({2})", i + 1, coursesToEnroll[i].GetCourseName(), coursesToEnroll[i].GetCourseCode());
                    }

                    int courseToEnrollIndex = int.Parse(Console.ReadLine()) - 1;

                    if (courseToEnrollIndex >= 0 && courseToEnrollIndex < coursesToEnroll.Count)
                    {
                        Course courseToEnroll = coursesToEnroll[courseToEnrollIndex];

                        Console.WriteLine("Enter student name:");
                        string studentName = Console.ReadLine();

                        Console.WriteLine("Enter student ID:");
                        int studentID = int.Parse(Console.ReadLine());

                        
                        Console.WriteLine("Student enrolled in course.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid course selection.");
                    }
                    break;
                case "5":
                    Console.WriteLine("Logging out...");
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
    }
}