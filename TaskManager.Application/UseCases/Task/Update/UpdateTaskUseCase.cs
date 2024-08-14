
using TaskManager.Communication.Entities;
using TaskManager.Communication.Requests;

namespace TaskManager.Application.UseCases.Task.Update;

public class UpdateTaskUseCase
{
    public void Execute(int id, List<TaskType> tasks, RequestTaskJson request)
    {
        var task = tasks.Find(task => task.Id == id)!;

        task.Status = request.Status;
        task.Deadline = request.Deadline;
        task.Priority = request.Priority;
        task.Name = request.Name;
        task.Description = request.Description; 
      
    }
}
