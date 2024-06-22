using KanbanBoard.Enums;

namespace KanbanBoard.Models;

public class TaskItem
{
    public string? TaskName { get; set; }
    public TaskPriority Priority { get; set; }
    public ColumnName ColumnName { get; set; }
}