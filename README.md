# Kovsie Study and Assignment Tracker

## Team

- **Team name:** Team 11
- **Team members:**
  - Relebuhile Mokanyane
  - Moeletsi Phakedi
  - Oluga Mutavhatsindi
  - Noluthando Buda

### Contribution highlights

- **Moeletsi Phakedi** — created the initial skeletal design.
- **Noluthando Buda** — implemented the assignment filters and additional
  application functionality.

## Project description

Kovsie Study and Assignment Tracker is a Windows Forms desktop application that helps
students manage assignments across modules. Users can add modules and assignments,
set due dates, mark work as complete, search and sort their work, identify overdue
items, view a study schedule, and keep their data between launches.

The application is built with C# and .NET Framework 4.7.2. Assignment data is saved
as JSON and module data as plain text under the user's `%AppData%` directory.

## AI disclosure

AI tools were used during development to help with code organization, debugging,
documentation, and refinement. The team reviewed, tested, and understands the
submitted implementation.

## Running the project

1. Install Visual Studio with the .NET desktop development workload.
2. Open [`Kovsie Study and Assignment Tracker/Kovsie Study and Assignment Tracker.sln`](Kovsie%20Study%20and%20Assignment%20Tracker/Kovsie%20Study%20and%20Assignment%20Tracker.sln).
3. Build and run the solution with the **Debug** configuration.

The project targets .NET Framework 4.7.2 and is intended for Windows.

## Presentation notes

### What to demonstrate

- Add a module and assignment, including due-date validation.
- Search, sort, edit, complete, and delete assignments.
- Show the colour-coded overdue/completed list and the overdue-only filter.
- Open the summary and study schedule views.
- Restart the app to demonstrate JSON and module persistence.

### What we are proud of

The project combines a practical student workflow with a clear desktop UI,
validation, persistence, and live study-planning feedback instead of only storing
assignments in memory.

### Skills learned

- Building a multi-tab Windows Forms interface.
- Modeling application data with C# classes and LINQ.
- Persisting and reloading user data.
- Designing validation and user feedback for desktop applications.
- Structuring a project for maintainability and presentation.

### Challenges faced

- Keeping the UI responsive while supporting several assignment workflows.
- Safely mapping selected list rows back to the underlying assignment objects.
- Handling overdue dates, sorting, filtering, and persistence consistently.
- Consolidating multiple development copies into one clean, reproducible solution.
