
using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Entities;

public class TaskType
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public TaskPriority Priority { get; set; }

    public TaskCurrentStatus Status { get; set; }

    public DateTime Deadline { get; set; }
}
