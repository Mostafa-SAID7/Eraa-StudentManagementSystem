# Eraa-StudentManagementSystem

This is a beginner-friendly **Student Management System** built using **Object-Oriented Programming (OOP)** principles in C#. The project is implemented as a **console application** without the use of databases or advanced C# features, making it ideal for students learning OOP basics.
<p align="center">
  <a href="https://drive.google.com/file/d/1nDRjhbqct12RlGyURuJaomuu0FQKosYx/view?usp=sharing" 
     style="display:inline-flex; align-items:center; background-color:#1DA1F2; color:#fff; font-weight:bold; 
            padding:12px 25px; text-decoration:none; border-radius:30px; box-shadow:0 4px 6px rgba(0,0,0,0.1);" 
     target="_blank" 
     rel="noopener noreferrer">
    <img src="https://cdn-icons-png.flaticon.com/512/337/337946.png" alt="PDF Icon" width="20" height="20" style="margin-right:8px;" />
    📄 View: Struct vs Class vs Record (PDF)
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

---
