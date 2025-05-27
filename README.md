# Eraa-StudentManagementSystem

This is a beginner-friendly **Student Management System** built using **Object-Oriented Programming (OOP)** principles in C#. The project is implemented as a **console application** without the use of databases or advanced C# features, making it ideal for students learning OOP basics.
<p align="center">
  <a href="https://drive.google.com/file/d/1nDRjhbqct12RlGyURuJaomuu0FQKosYx/view?usp=sharing" target="_blank" rel="noopener noreferrer">
    <img src="https://img.shields.io/badge/PDF-View%20Struct%20vs%20Class%20vs%20Record-D44638?style=flat&logo=adobe&logoColor=white" alt="View PDF" />
  </a>
</p>


---

## 💡 Features

- Add a new **Student**
- Add a new **Instructor**
- Add a new **Course**
- Enroll a **Student** in a **Course**
- View all **Students**, **Courses**, and **Instructors**
- Search for **Student** or **Course** by ID
- Check if a **Student** is enrolled in a specific **Course**
- Get **Instructor Name** by **Course Title**

---

## 🏗️ Classes Used

### `Student`
- `int StudentId`
- `string Name`
- `int Age`
- `List<Course> Courses`
- Methods: `Enroll()`, `PrintDetails()`, Getters/Setters

### `Instructor`
- `int InstructorId`
- `string Name`
- `string Specialization`
- Methods: `PrintDetails()`, Getters/Setters

### `Course`
- `int CourseId`
- `string Title`
- `Instructor Instructor`
- Methods: `PrintDetails()`, Getters/Setters

### `StudentManager`
- Manages lists of Students, Courses, and Instructors
- Methods:
  - `AddStudent()`
  - `AddInstructor()`
  - `AddCourse()`
  - `EnrollStudentInCourse()`
  - `FindStudent()`
  - `FindInstructor()`
  - `FindCourse()`
  - `IsStudentEnrolledInCourse()`
  - `GetInstructorNameByCourseTitle()`

---

## ▶️ How to Run

1. Open the project in **Visual Studio** or any C# IDE.
2. Build the solution.
3. Run the program from the console.
4. Follow the menu instructions to manage students, instructors, and courses.

---

## ❗ Notes

- The code avoids modern C# syntax like:
  - `get; set;`
  - `=>` (lambda expressions)
  - LINQ
  - String interpolation (`$""`)
- Instead, it uses **classic OOP and full method definitions** to reinforce beginner concepts.

