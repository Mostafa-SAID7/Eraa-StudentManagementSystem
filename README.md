<div style="display: flex; justify-content: space-between; align-items: center;">
  <h1 style="margin: 0;">Eraa-StudentManagementSystem</h1>
  <p align="center">
 <a href="https://drive.google.com/file/d/1nDRjhbqct12RlGyURuJaomuu0FQKosYx/view?usp=sharing" target="_blank" rel="noopener noreferrer">
    <img src="https://img.shields.io/badge/PDF-View%20Struct%20vs%20Class%20vs%20Record-D44638?style=flat&logo=adobe&logoColor=white" alt="View PDF" />
  </a>
  <a href="https://www.facebook.com/eraasoft" target="_blank" rel="noopener noreferrer">
    <img src="https://img.shields.io/badge/Built%20with-Eraa%20Soft%20Training%20Program-1877F2?style=flat&logo=facebook&logoColor=white" alt="Eraa Soft Training Program" />
  </a>
 <a href="https://github.com/Mostafa-SAID7" target="_blank" rel="noopener noreferrer">
  <img src="https://img.shields.io/badge/Author-Mostafa--SAID7-000?style=flat&logo=github&logoColor=white" alt="Author: Mostafa-SAID7" />
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
<h3 align="left" style="color:#2F80ED;">📘 Class: <code style="background:#f4f4f4; padding:2px 6px; border-radius:4px;">Student</code></h3>

<table style="width:100%; border-collapse:collapse; margin-bottom:20px;">
  <tr style="background:#e8f0fe; text-align:center; font-weight:bold; color:#2F80ED;">
    <td style="border:1px solid #ddd; padding:12px; width:50%;">📦 Properties</td>
    <td style="border:1px solid #ddd; padding:12px; width:50%;">🔧 Methods</td>
  </tr>
  <tr style="vertical-align:top;">
    <td style="border:1px solid #ddd; padding:12px;">
      <ul style="list-style-type:none; padding-left:0; color:#333; font-family: 'Courier New', Courier, monospace;">
        <li><code>int StudentId</code></li>
        <li><code>string Name</code></li>
        <li><code>int Age</code></li>
        <li><code>List&lt;Course&gt; Courses</code></li>
      </ul>
    </td>
    <td style="border:1px solid #ddd; padding:12px;">
      <ul style="list-style-type:none; padding-left:0; color:#333; font-family: 'Courier New', Courier, monospace;">
        <li><code>bool Enroll(Course course)</code></li>
        <li><code>string PrintDetails()</code></li>
        <li><code>void UpdateInfo(string name, int age)</code></li>
      </ul>
    </td>
  </tr>
</table>

---

<h3 align="left" style="color:#2F80ED;">📘 Class: <code style="background:#f4f4f4; padding:2px 6px; border-radius:4px;">Instructor</code></h3>

<table style="width:100%; border-collapse:collapse; margin-bottom:20px;">
  <tr style="background:#e8f0fe; text-align:center; font-weight:bold; color:#2F80ED;">
    <td style="border:1px solid #ddd; padding:12px; width:50%;">📦 Properties</td>
    <td style="border:1px solid #ddd; padding:12px; width:50%;">🔧 Methods</td>
  </tr>
  <tr style="vertical-align:top;">
    <td style="border:1px solid #ddd; padding:12px;">
      <ul style="list-style-type:none; padding-left:0; color:#333; font-family: 'Courier New', Courier, monospace;">
        <li><code>int InstructorId</code></li>
        <li><code>string Name</code></li>
        <li><code>string Specialization</code></li>
      </ul>
    </td>
    <td style="border:1px solid #ddd; padding:12px;">
      <ul style="list-style-type:none; padding-left:0; color:#333; font-family: 'Courier New', Courier, monospace;">
        <li><code>string PrintDetails()</code></li>
      </ul>
    </td>
  </tr>
</table>

---

<h3 align="left" style="color:#2F80ED;">📘 Class: <code style="background:#f4f4f4; padding:2px 6px; border-radius:4px;">Course</code></h3>

<table style="width:100%; border-collapse:collapse; margin-bottom:20px;">
  <tr style="background:#e8f0fe; text-align:center; font-weight:bold; color:#2F80ED;">
    <td style="border:1px solid #ddd; padding:12px; width:50%;">📦 Properties</td>
    <td style="border:1px solid #ddd; padding:12px; width:50%;">🔧 Methods</td>
  </tr>
  <tr style="vertical-align:top;">
    <td style="border:1px solid #ddd; padding:12px;">
      <ul style="list-style-type:none; padding-left:0; color:#333; font-family: 'Courier New', Courier, monospace;">
        <li><code>int CourseId</code></li>
        <li><code>string Title</code></li>
        <li><code>Instructor Instructor</code></li>
      </ul>
    </td>
    <td style="border:1px solid #ddd; padding:12px;">
      <ul style="list-style-type:none; padding-left:0; color:#333; font-family: 'Courier New', Courier, monospace;">
        <li><code>string PrintDetails()</code></li>
      </ul>
    </td>
  </tr>
</table>

---

<h3 align="left" style="color:#2F80ED;">📘 Class: <code style="background:#f4f4f4; padding:2px 6px; border-radius:4px;">StudentManager</code></h3>

<table style="width:100%; border-collapse:collapse; margin-bottom:40px;">
  <tr style="background:#e8f0fe; font-weight:bold; color:#2F80ED;">
    <td colspan="2" style="border:1px solid #ddd; padding:12px; text-align:center; font-size:1.1em;">📃 Description</td>
  </tr>
  <tr>
    <td colspan="2" style="border:1px solid #ddd; padding:12px; font-style:italic; color:#444; text-align:center;">
      Manages lists of <code>Students</code>, <code>Courses</code>, and <code>Instructors</code>.
    </td>
  </tr>
  <tr style="background:#e8f0fe; text-align:center; font-weight:bold; color:#2F80ED;">
    <td style="border:1px solid #ddd; padding:12px; width:50%;">🔧 Methods</td>
    <td style="border:1px solid #ddd; padding:12px; width:50%;"></td>
  </tr>
  <tr style="vertical-align:top;">
    <td colspan="2" style="border:1px solid #ddd; padding:12px; font-family: 'Courier New', Courier, monospace; color:#333;">
      <ul style="list-style-type:disc; padding-left:20px;">
        <li><code>bool AddStudent(Student student)</code></li>
        <li><code>bool UpdateStudent(int studentId, string newName, int newAge)</code></li>
        <li><code>bool DeleteStudent(int studentId)</code></li>
        <li><code>bool AddInstructor(Instructor instructor)</code></li>
        <li><code>bool AddCourse(Course course)</code></li>
        <li><code>bool EnrollStudentInCourse(int studentId, int courseId)</code></li>
        <li><code>Student FindStudent(string input)</code></li>
        <li><code>Instructor FindInstructor(int instructorId)</code></li>
        <li><code>Course FindCourse(string input)</code></li>
        <li><code>bool IsStudentEnrolledInCourse(int studentId, int courseId)</code></li>
        <li><code>string GetInstructorNameByCourseTitle(string title)</code></li>
        <li><em>Methods to list all Students, Courses, and Instructors with detailed display</em></li>
      </ul>
    </td>
  </tr>
</table>

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




