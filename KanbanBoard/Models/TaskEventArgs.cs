using KanbanBoard.Enums;

namespace KanbanBoard.Models;

public class TaskEventArgs(string taskName, TaskPriority priority)
{
    public string TaskName { get; set; } = taskName;
    public TaskPriority Priority { get; set; } = priority;
}