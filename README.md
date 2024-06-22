```markdown
# Blazor Kanban Board

A Kanban Board application built with Blazor, featuring dark theme support.

## Description

Blazor Kanban Board is a simple web application for managing tasks in a Kanban style. The application supports toggling between light and dark themes for a better user experience.

## Features

- Add new tasks
- Drag and drop tasks between columns
- Toggle between light and dark themes

## Installation

1. Clone the repository:

   ```sh
   git clone https://github.com/Rafah46/blazor-kanban-board.git
   ```

2. Navigate to the project directory:

   ```sh
   cd blazor-kanban-board
   ```

3. Restore project dependencies:

   ```sh
   dotnet restore
   ```

4. Run the application:

   ```sh
   dotnet run
   ```

5. Open your browser and navigate to `https://localhost:5001` to see the application in action.

## Project Structure

```plaintext
blazor-kanban-board/
│
├── wwwroot/
│   ├── css/
│   │   └── app.css
│   └── index.html
|
├── Enums/
│   ├── ColumnName.cs
│   └── TaskPriority.cs
│
├── Layout/
│   └── MainLayout.razor
│
├── Models/
│   ├── TaskEventArgs.cs
│   └── TaskItem.cs
│
├── Pages/
│   └── Home.razor
│
├── Shared/
│   ├── Dropzone.razor
│   ├── NewTask.razor
│   └── ToggleTheme.razor
│
├── _Imports.razor
├── App.razor
├── Program.cs
└── README.md
```

## Usage

### Add a New Task

1. Enter the task name in the "New Task" field.
2. Select the task priority using the dropdown.
3. Click the "Save Task" button to add the task.

### Move Tasks

1. Drag a task from its current column.
2. Drop the task in the desired column.

### Toggle Theme

1. Use the theme toggle switch at the top of the page to switch between light and dark themes.

## Technologies Used

- [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
- [.NET 8](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Bootstrap](https://getbootstrap.com/)
- HTML/CSS/JavaScript

## Contribution

If you wish to contribute to this project, feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
```

Make sure to adjust the URLs and any specific information according to your actual project details.