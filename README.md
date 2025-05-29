<div style="display: flex; justify-content: space-between; align-items: center;">
  <h1 style="margin: 0;">Eraa-StudentManagementSystem</h1>
  <p align="center">
 

  <a href="https://www.facebook.com/eraasoft" target="_blank" rel="noopener noreferrer">
    <img src="https://img.shields.io/badge/Built%20with-Eraa%20Soft%20Training%20Program-1877F2?style=flat&logo=facebook&logoColor=white" alt="Eraa Soft Training Program" />
  </a>
   <a href="https://drive.google.com/file/d/1nDRjhbqct12RlGyURuJaomuu0FQKosYx/view?usp=sharing" target="_blank" rel="noopener noreferrer">
    <img src="https://img.shields.io/badge/PDF-View%20Struct%20vs%20Class%20vs%20Record-D44638?style=flat&logo=adobe&logoColor=white" alt="View PDF" />
  </a>
  <a>
    Mostafa SAID 
  </a>
  </p>
</div>


This is a beginner-friendly **Student Management System** built using **Object-Oriented Programming (OOP)** principles in C#. The project is implemented as a **console application** without databases or advanced C# features, making it ideal for students learning OOP basics.



---

## 💡 Features

- Add, update, and delete **Students**
- Add new **Instructors**
- Add new **Courses** with assigned instructors
- Enroll a **Student** in a **Course**
- View all **Students**, **Courses**, and **Instructors**
- Search for **Student** or **Course** by ID or Name/Title
- Check if a **Student** is enrolled in a specific **Course**
- Get **Instructor Name** by **Course Title**
- Display detailed student information including enrolled courses
- Improved console interaction with input validations and error feedback
- Nicely formatted console outputs for clearer user experience

---

## 🏗️ Classes Used

### `Student`
- **Properties**:
  - `int StudentId`
  - `string Name`
  - `int Age`
  - `List<Course> Courses`
- **Methods**:
  - `bool Enroll(Course course)`
  - `string PrintDetails()`
  - `void UpdateInfo(string name, int age)`

### `Instructor`
- **Properties**:
  - `int InstructorId`
  - `string Name`
  - `string Specialization`
- **Methods**:
  - `string PrintDetails()`

### `Course`
- **Properties**:
  - `int CourseId`
  - `string Title`
  - `Instructor Instructor`
- **Methods**:
  - `string PrintDetails()`

### `StudentManager`
- **Description**: Manages lists of Students, Courses, and Instructors.
- **Methods**:
  - `bool AddStudent(Student student)`
  - `bool UpdateStudent(int studentId, string newName, int newAge)`
  - `bool DeleteStudent(int studentId)`
  - `bool AddInstructor(Instructor instructor)`
  - `bool AddCourse(Course course)`
  - `bool EnrollStudentInCourse(int studentId, int courseId)`
  - `Student FindStudent(string input)`
  - `Instructor FindInstructor(int instructorId)`
  - `Course FindCourse(string input)`
  - `bool IsStudentEnrolledInCourse(int studentId, int courseId)`
  - `string GetInstructorNameByCourseTitle(string title)`
  - Methods to list all Students, Courses, and Instructors with detailed display

---

## ▶️ How to Run

1. Open the project in **Visual Studio** or any C# IDE.
2. Build the solution.
3. Run the console application.
4. Use the interactive menu to add, update, delete, enroll, and search entities.
5. Follow prompts carefully; invalid inputs will request re-entry until valid.

---

## ❗ Notes

- This project prioritizes clear demonstration of **classic OOP** concepts for learners.
- It uses full method definitions and manual data handling for educational clarity.
- No external dependencies or database technologies are used.
- Console color and formatting are minimal but can be extended for better UX.




