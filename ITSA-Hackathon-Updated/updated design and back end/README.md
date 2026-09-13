# Kovsie Study and Assignment Tracker

A Windows Forms desktop app built for the ITSA Hackathon brief:

> Build an application that helps a first-year student manage their assignments across
> modules: capture the module, assignment name, due date, and completion status, and
> flag overdue items.

## Features

- **Module management** — add modules (validated against the `ABCD1234` code format),
  remove unused modules, and view a quick per-module count of total/completed/overdue
  assignments.
- **Assignment CRUD** — add, view, edit, mark complete, and delete assignments through
  standard Windows Forms controls (buttons, text boxes, a combo box, date pickers, and a
  list box). No console input or output anywhere in the app.
- **Overdue flagging** — the assignment list is colour-coded (red = overdue, green =
  completed, black = upcoming), and a dedicated toggle switches between "all
  assignments" and "overdue only".
- **Search and sort** — free-text search across module and title, plus a sort button
  that cycles through due date, module, and title (each ascending/descending).
- **Summary / report view** — live counts of total assignments, overdue assignments,
  and modules tracked, plus a per-module breakdown built by iterating the assignment
  collection.
- **Study Schedule tab** — a lightweight weekly planner that lists anything overdue
  first, then everything due in the next 7 days, grouped by day.
- **Input validation** — module codes, assignment titles, and module/date selections
  are all validated with clear message boxes; nothing crashes on empty or malformed
  input.
- **Persistence** — assignments are saved as JSON (`DataContractJsonSerializer`) and
  modules as a plain text list, both under
  `%AppData%\KovsieStudyAndAssignmentTracker\`, and reloaded automatically on startup.

## Architecture

- `Assignment.cs` — the `Assignment` class (`Module`, `Title`, `DueDate`,
  `IsCompleted`, plus computed `IsOverdue`/`DaysRemaining`/`StatusText`) used instead of
  parallel arrays.
- `Study And Assignment Tracker.cs` — the form's code-behind. Event handlers are kept
  thin; they call well-named helper methods (`TryValidateAssignmentInput`,
  `GetVisibleAssignments`, `SortAssignments`, `BuildModuleSummaryText`,
  `BuildStudyPlanText`, etc.) that take parameters and return values.
- `List<Assignment>` is the in-memory collection, bound to a `ListBox` for display.

## Running the project

Open `Kovsie Study and Assignment Tracker.sln` in Visual Studio (targets .NET Framework
4.7.2) and press Start. On first run the app seeds three sample modules/assignments so
the UI isn't empty; delete `%AppData%\KovsieStudyAndAssignmentTracker\assignments.json`
to reset.
