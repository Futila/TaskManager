
using TaskManager.Communication.Entities;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetById;

public class GetTaskByIdUseCase
{
    public TaskType Execute(int id, List<TaskType> tasks)
    {
       var task = tasks.Find(task => task.Id == id)!;

       return task;
    }
}
