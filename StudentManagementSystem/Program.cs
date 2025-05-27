using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();

            while (true)
            {
                Console.WriteLine("\n--- Student Management System ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Instructor");
                Console.WriteLine("3. Add Course");
                Console.WriteLine("4. Enroll Student in Course");
                Console.WriteLine("5. Show All Students");
                Console.WriteLine("6. Show All Courses");
                Console.WriteLine("7. Show All Instructors");
                Console.WriteLine("8. Find Student by ID");
                Console.WriteLine("9. Find Course by ID");
                Console.WriteLine("10. Exit");
                Console.WriteLine("11. Check if Student Enrolled in Course");
                Console.WriteLine("12. Get Instructor Name by Course Title");
                Console.Write("Select option: ");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Student student = new Student();
                    Console.Write("Enter Student ID: ");
                    student.SetStudentId(Convert.ToInt32(Console.ReadLine()));
                    Console.Write("Enter Name: ");
                    student.SetName(Console.ReadLine());
                    Console.Write("Enter Age: ");
                    student.SetAge(Convert.ToInt32(Console.ReadLine()));
                    manager.AddStudent(student);
                }
                else if (option == "2")
                {
                    Instructor instructor = new Instructor();
                    Console.Write("Enter Instructor ID: ");
                    instructor.SetInstructorId(Convert.ToInt32(Console.ReadLine()));
                    Console.Write("Enter Name: ");
                    instructor.SetName(Console.ReadLine());
                    Console.Write("Enter Specialization: ");
                    instructor.SetSpecialization(Console.ReadLine());
                    manager.AddInstructor(instructor);
                }
                else if (option == "3")
                {
                    Course course = new Course();
                    Console.Write("Enter Course ID: ");
                    course.SetCourseId(Convert.ToInt32(Console.ReadLine()));
                    Console.Write("Enter Title: ");
                    course.SetTitle(Console.ReadLine());
                    Console.Write("Enter Instructor ID: ");
                    int iid = Convert.ToInt32(Console.ReadLine());
                    Instructor foundInstructor = manager.FindInstructor(iid);
                    if (foundInstructor != null)
                    {
                        course.SetInstructor(foundInstructor);
                        manager.AddCourse(course);
                    }
                    else
                    {
                        Console.WriteLine("Instructor not found.");
                    }
                }
                else if (option == "4")
                {
                    Console.Write("Enter Student ID: ");
                    int sid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Course ID: ");
                    int cid = Convert.ToInt32(Console.ReadLine());
                    manager.EnrollStudentInCourse(sid, cid);
                }
                else if (option == "5")
                {
                    List<Student> allStudents = manager.GetStudents();
                    for (int i = 0; i < allStudents.Count; i++)
                    {
                        Console.WriteLine(allStudents[i].PrintDetails());
                    }
                }
                else if (option == "6")
                {
                    List<Course> allCourses = manager.GetCourses();
                    for (int i = 0; i < allCourses.Count; i++)
                    {
                        Console.WriteLine(allCourses[i].PrintDetails());
                    }
                }
                else if (option == "7")
                {
                    List<Instructor> allInstructors = manager.GetInstructors();
                    for (int i = 0; i < allInstructors.Count; i++)
                    {
                        Console.WriteLine(allInstructors[i].PrintDetails());
                    }
                }
                else if (option == "8")
                {
                    Console.Write("Enter Student ID: ");
                    Student foundStudent = manager.FindStudent(Convert.ToInt32(Console.ReadLine()));
                    if (foundStudent != null)
                    {
                        Console.WriteLine(foundStudent.PrintDetails());
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                }
                else if (option == "9")
                {
                    Console.Write("Enter Course ID: ");
                    Course foundCourse = manager.FindCourse(Convert.ToInt32(Console.ReadLine()));
                    if (foundCourse != null)
                    {
                        Console.WriteLine(foundCourse.PrintDetails());
                    }
                    else
                    {
                        Console.WriteLine("Course not found.");
                    }
                }
                else if (option == "10")
                {
                    break;
                }
                else if (option == "11")
                {
                    Console.Write("Enter Student ID: ");
                    int studentId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Course ID: ");
                    int courseId = Convert.ToInt32(Console.ReadLine());

                    bool enrolled = manager.IsStudentEnrolledInCourse(studentId, courseId);
                    if (enrolled)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
                else if (option == "12")
                {
                    Console.Write("Enter Course Title: ");
                    string title = Console.ReadLine();
                    string name = manager.GetInstructorNameByCourseTitle(title);
                    Console.WriteLine("Instructor: " + name);
                }
            }
        }
    }

    class Student
    {
        private int studentId;
        private string name;
        private int age;
        private List<Course> courses;

        public Student()
        {
            courses = new List<Course>();
        }

        public void SetStudentId(int id) { studentId = id; }
        public int GetStudentId() { return studentId; }

        public void SetName(string n) { name = n; }
        public string GetName() { return name; }

        public void SetAge(int a) { age = a; }
        public int GetAge() { return age; }

        public List<Course> GetCourses() { return courses; }

        public bool Enroll(Course course)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].GetCourseId() == course.GetCourseId())
                {
                    return false;
                }
            }
            courses.Add(course);
            return true;
        }

        public string PrintDetails()
        {
            string result = "ID: " + studentId + ", Name: " + name + ", Age: " + age + ", Courses: ";
            if (courses.Count == 0)
            {
                result += "None";
            }
            else
            {
                for (int i = 0; i < courses.Count; i++)
                {
                    result += courses[i].GetTitle();
                    if (i < courses.Count - 1)
                    {
                        result += ", ";
                    }
                }
            }
            return result;
        }
    }

    class Instructor
    {
        private int instructorId;
        private string name;
        private string specialization;

        public void SetInstructorId(int id) { instructorId = id; }
        public int GetInstructorId() { return instructorId; }

        public void SetName(string n) { name = n; }
        public string GetName() { return name; }

        public void SetSpecialization(string s) { specialization = s; }
        public string GetSpecialization() { return specialization; }

        public string PrintDetails()
        {
            return "ID: " + instructorId + ", Name: " + name + ", Specialization: " + specialization;
        }
    }

    class Course
    {
        private int courseId;
        private string title;
        private Instructor instructor;

        public void SetCourseId(int id) { courseId = id; }
        public int GetCourseId() { return courseId; }

        public void SetTitle(string t) { title = t; }
        public string GetTitle() { return title; }

        public void SetInstructor(Instructor i) { instructor = i; }
        public Instructor GetInstructor() { return instructor; }

        public string PrintDetails()
        {
            string instructorName = "None";
            if (instructor != null)
            {
                instructorName = instructor.GetName();
            }

            return "ID: " + courseId + ", Title: " + title + ", Instructor: " + instructorName;
        }
    }

    class StudentManager
    {
        private List<Student> students;
        private List<Course> courses;
        private List<Instructor> instructors;

        public StudentManager()
        {
            students = new List<Student>();
            courses = new List<Course>();
            instructors = new List<Instructor>();
        }

        public List<Student> GetStudents() { return students; }
        public List<Course> GetCourses() { return courses; }
        public List<Instructor> GetInstructors() { return instructors; }

        public bool AddStudent(Student s)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].GetStudentId() == s.GetStudentId())
                {
                    Console.WriteLine("Student ID already exists.");
                    return false;
                }
            }
            students.Add(s);
            Console.WriteLine("Student added.");
            return true;
        }

        public bool AddInstructor(Instructor i)
        {
            for (int j = 0; j < instructors.Count; j++)
            {
                if (instructors[j].GetInstructorId() == i.GetInstructorId())
                {
                    Console.WriteLine("Instructor ID already exists.");
                    return false;
                }
            }
            instructors.Add(i);
            Console.WriteLine("Instructor added.");
            return true;
        }

        public bool AddCourse(Course c)
        {
            for (int k = 0; k < courses.Count; k++)
            {
                if (courses[k].GetCourseId() == c.GetCourseId())
                {
                    Console.WriteLine("Course ID already exists.");
                    return false;
                }
            }
            courses.Add(c);
            Console.WriteLine("Course added.");
            return true;
        }

        public Student FindStudent(int id)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].GetStudentId() == id)
                {
                    return students[i];
                }
            }
            return null;
        }

        public Instructor FindInstructor(int id)
        {
            for (int i = 0; i < instructors.Count; i++)
            {
                if (instructors[i].GetInstructorId() == id)
                {
                    return instructors[i];
                }
            }
            return null;
        }

        public Course FindCourse(int id)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].GetCourseId() == id)
                {
                    return courses[i];
                }
            }
            return null;
        }

        public bool EnrollStudentInCourse(int studentId, int courseId)
        {
            Student student = FindStudent(studentId);
            Course course = FindCourse(courseId);
            if (student != null && course != null)
            {
                return student.Enroll(course);
            }
            return false;
        }

        public bool IsStudentEnrolledInCourse(int studentId, int courseId)
        {
            Student student = FindStudent(studentId);
            if (student != null)
            {
                List<Course> enrolledCourses = student.GetCourses();
                for (int i = 0; i < enrolledCourses.Count; i++)
                {
                    if (enrolledCourses[i].GetCourseId() == courseId)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public string GetInstructorNameByCourseTitle(string title)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].GetTitle().ToLower() == title.ToLower())
                {
                    Instructor instr = courses[i].GetInstructor();
                    if (instr != null)
                    {
                        return instr.GetName();
                    }
                }
            }
            return "Not found";
        }
    }
}
