# Console Learning Management System (Mini LMS)

A console-based Learning Management System built in **C#** applying Object-Oriented Programming (OOP) principles, clean folder separation, and role-based workflows for instructors and students.

## Features

- **Authentication & Role Routing:** Register new accounts, log in with phone and password, and route users automatically to either the **Instructor Dashboard** or the **Student Portal** based on their role.
- **Instructor Dashboard:**
  - Create new courses with title, description, and validated pricing.
  - View courses created by the logged-in instructor.
- **Student Portal:**
  - Browse all available courses in the system.
  - Enroll in courses with duplicate-enrollment protection and safe input parsing.
  - View enrolled courses.

## Project Structure

- `Models/` — Domain entities (`User`, `Student`, `Instructor`, `Course`).
- `Services/` — Business logic and operations (`UserService`, `CourseService`).
- `Data/` — In-memory data store (`InMemoryDatabase`).
- `UI/` — Console screens and user flows (`InstructorDashboard`, `StudentPortal`).
- `Program.cs` — Application entry point and main navigation loop.

## Getting Started

1. Clone the repository:
   ```bash
   git clone [https://github.com/elsehs/LMS.git](https://github.com/elsehs/LMS.git)
