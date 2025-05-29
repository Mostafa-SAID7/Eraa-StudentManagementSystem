using System;
using System.Collections.Generic;

public class Student
{
    private int studentId;
    private string name;
    private int age;
    private List<Course> courses = new List<Course>();

    public void SetStudentId(int id) { studentId = id; }
    public void SetName(string n) { name = n; }
    public void SetAge(int a) { age = a; }

    public int GetStudentId() { return studentId; }
    public string GetName() { return name; }
    public int GetAge() { return age; }
    public List<Course> GetCourses() { return courses; }

    public bool Enroll(Course course)
    {
        foreach (Course c in courses)
        {
            if (c.GetCourseId() == course.GetCourseId())
            {
                return false;
            }
        }
        courses.Add(course);
        return true;
    }

    public string PrintDetails()
    {
        return "ID: " + studentId + ", Name: " + name + ", Age: " + age + ", Courses: " + courses.Count;
    }
}

public class Instructor
{
    private int instructorId;
    private string name;
    private string specialization;

    public void SetInstructorId(int id) { instructorId = id; }
    public void SetName(string n) { name = n; }
    public void SetSpecialization(string s) { specialization = s; }

    public int GetInstructorId() { return instructorId; }
    public string GetName() { return name; }
    public string GetSpecialization() { return specialization; }

    public string PrintDetails()
    {
        return "ID: " + instructorId + ", Name: " + name + ", Specialization: " + specialization;
    }
}

public class Course
{
    private int courseId;
    private string title;
    private Instructor instructor;

    public void SetCourseId(int id) { courseId = id; }
    public void SetTitle(string t) { title = t; }
    public void SetInstructor(Instructor i) { instructor = i; }

    public int GetCourseId() { return courseId; }
    public string GetTitle() { return title; }
    public Instructor GetInstructor() { return instructor; }

    public string PrintDetails()
    {
        string instructorName = instructor != null ? instructor.GetName() : "None";
        return "ID: " + courseId + ", Title: " + title + ", Instructor: " + instructorName;
    }
}

public class StudentManager
{
    private List<Student> students = new List<Student>();
    private List<Course> courses = new List<Course>();
    private List<Instructor> instructors = new List<Instructor>();

    public bool AddStudent(Student student)
    {
        foreach (Student s in students)
        {
            if (s.GetStudentId() == student.GetStudentId())
            {
                Console.WriteLine("Student ID already exists.");
                return false;
            }
        }
        students.Add(student);
        return true;
    }

    public bool AddInstructor(Instructor instructor)
    {
        foreach (Instructor i in instructors)
        {
            if (i.GetInstructorId() == instructor.GetInstructorId())
            {
                Console.WriteLine("Instructor ID already exists.");
                return false;
            }
        }
        instructors.Add(instructor);
        return true;
    }

    public bool AddCourse(Course course)
    {
        foreach (Course c in courses)
        {
            if (c.GetCourseId() == course.GetCourseId())
            {
                Console.WriteLine("Course ID already exists.");
                return false;
            }
        }
        courses.Add(course);
        return true;
    }

    public Student FindStudent(string input)
    {
        foreach (Student s in students)
        {
            if (s.GetStudentId().ToString() == input || s.GetName().ToLower() == input.ToLower())
            {
                return s;
            }
        }
        return null;
    }

    public Course FindCourse(string input)
    {
        foreach (Course c in courses)
        {
            if (c.GetCourseId().ToString() == input || c.GetTitle().ToLower() == input.ToLower())
            {
                return c;
            }
        }
        return null;
    }

    public Instructor FindInstructor(int id)
    {
        foreach (Instructor i in instructors)
        {
            if (i.GetInstructorId() == id)
            {
                return i;
            }
        }
        return null;
    }

    public bool EnrollStudentInCourse(int studentId, int courseId)
    {
        Student student = FindStudent(studentId.ToString());
        Course course = FindCourse(courseId.ToString());
        if (student != null && course != null)
        {
            return student.Enroll(course);
        }
        return false;
    }

    public bool IsStudentEnrolledInCourse(int studentId, int courseId)
    {
        Student student = FindStudent(studentId.ToString());
        if (student != null)
        {
            List<Course> studentCourses = student.GetCourses();
            foreach (Course course in studentCourses)
            {
                if (course.GetCourseId() == courseId)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public string GetInstructorNameByCourseTitle(string title)
    {
        Course course = FindCourse(title);
        if (course != null && course.GetInstructor() != null)
        {
            return course.GetInstructor().GetName();
        }
        return null;
    }

    public List<Student> GetStudents() { return students; }
    public List<Course> GetCourses() { return courses; }
    public List<Instructor> GetInstructors() { return instructors; }
}

class Program
{
    static void Main(string[] args)
    {
        StudentManager manager = new StudentManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Instructor");
            Console.WriteLine("3. Add Course");
            Console.WriteLine("4. Enroll Student in Course");
            Console.WriteLine("5. Show All Students");
            Console.WriteLine("6. Show All Courses");
            Console.WriteLine("7. Show All Instructors");
            Console.WriteLine("8. Find Student by ID or Name");
            Console.WriteLine("9. Find Course by ID or Title");
            Console.WriteLine("10. Check if Student is Enrolled in Course");
            Console.WriteLine("11. Get Instructor by Course Title");
            Console.WriteLine("12. Exit");
            Console.Write("Choose option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddStudent(manager);
                    break;
                case "2":
                    AddInstructor(manager);
                    break;
                case "3":
                    AddCourse(manager);
                    break;
                case "4":
                    EnrollStudent(manager);
                    break;
                case "5":
                    ShowStudents(manager);
                    break;
                case "6":
                    ShowCourses(manager);
                    break;
                case "7":
                    ShowInstructors(manager);
                    break;
                case "8":
                    FindStudent(manager);
                    break;
                case "9":
                    FindCourse(manager);
                    break;
                case "10":
                    CheckEnrollment(manager);
                    break;
                case "11":
                    GetInstructorByCourse(manager);
                    break;
                case "12":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void AddStudent(StudentManager manager)
    {
        Student student = new Student();
        Console.Write("Enter Student ID: ");
        student.SetStudentId(Convert.ToInt32(Console.ReadLine()));
        Console.Write("Enter Name: ");
        student.SetName(Console.ReadLine());
        Console.Write("Enter Age: ");
        student.SetAge(Convert.ToInt32(Console.ReadLine()));
        if (manager.AddStudent(student))
            Console.WriteLine("Student added successfully.");
    }

    static void AddInstructor(StudentManager manager)
    {
        Instructor instructor = new Instructor();
        Console.Write("Enter Instructor ID: ");
        instructor.SetInstructorId(Convert.ToInt32(Console.ReadLine()));
        Console.Write("Enter Name: ");
        instructor.SetName(Console.ReadLine());
        Console.Write("Enter Specialization: ");
        instructor.SetSpecialization(Console.ReadLine());
        if (manager.AddInstructor(instructor))
            Console.WriteLine("Instructor added successfully.");
    }

    static void AddCourse(StudentManager manager)
    {
        Course course = new Course();
        Console.Write("Enter Course ID: ");
        course.SetCourseId(Convert.ToInt32(Console.ReadLine()));
        Console.Write("Enter Title: ");
        course.SetTitle(Console.ReadLine());
        Console.Write("Enter Instructor ID: ");
        int instructorId = Convert.ToInt32(Console.ReadLine());

        Instructor instructor = manager.FindInstructor(instructorId);
        if (instructor != null)
        {
            course.SetInstructor(instructor);
            if (manager.AddCourse(course))
                Console.WriteLine("Course added successfully.");
        }
        else
        {
            Console.WriteLine("Instructor not found.");
        }
    }

    static void EnrollStudent(StudentManager manager)
    {
        Console.Write("Enter Student ID: ");
        int studentId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Course ID: ");
        int courseId = Convert.ToInt32(Console.ReadLine());

        if (manager.EnrollStudentInCourse(studentId, courseId))
            Console.WriteLine("Enrollment successful.");
        else
            Console.WriteLine("Enrollment failed.");
    }

    static void ShowStudents(StudentManager manager)
    {
        List<Student> students = manager.GetStudents();
        foreach (Student student in students)
        {
            Console.WriteLine(student.PrintDetails());
        }
    }

    static void ShowCourses(StudentManager manager)
    {
        List<Course> courses = manager.GetCourses();
        foreach (Course course in courses)
        {
            Console.WriteLine(course.PrintDetails());
        }
    }

    static void ShowInstructors(StudentManager manager)
    {
        List<Instructor> instructors = manager.GetInstructors();
        foreach (Instructor instructor in instructors)
        {
            Console.WriteLine(instructor.PrintDetails());
        }
    }

    static void FindStudent(StudentManager manager)
    {
        Console.Write("Enter Student ID or Name: ");
        string input = Console.ReadLine();
        Student student = manager.FindStudent(input);
        if (student != null)
            Console.WriteLine(student.PrintDetails());
        else
            Console.WriteLine("Student not found.");
    }

    static void FindCourse(StudentManager manager)
    {
        Console.Write("Enter Course ID or Title: ");
        string input = Console.ReadLine();
        Course course = manager.FindCourse(input);
        if (course != null)
            Console.WriteLine(course.PrintDetails());
        else
            Console.WriteLine("Course not found.");
    }

    static void CheckEnrollment(StudentManager manager)
    {
        Console.Write("Enter Student ID: ");
        int studentId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Course ID: ");
        int courseId = Convert.ToInt32(Console.ReadLine());

        if (manager.IsStudentEnrolledInCourse(studentId, courseId))
            Console.WriteLine("Yes, student is enrolled.");
        else
            Console.WriteLine("No, student is not enrolled.");
    }

    static void GetInstructorByCourse(StudentManager manager)
    {
        Console.Write("Enter Course Title: ");
        string title = Console.ReadLine();
        string instructor = manager.GetInstructorNameByCourseTitle(title);
        if (instructor != null)
            Console.WriteLine("Instructor: " + instructor);
        else
            Console.WriteLine("Course or instructor not found.");
    }
}
