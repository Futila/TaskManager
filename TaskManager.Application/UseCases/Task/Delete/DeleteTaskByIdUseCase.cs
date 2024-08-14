
using TaskManager.Communication.Entities;
using TaskManager.Communication.Requests;

namespace TaskManager.Application.UseCases.Task.Delete;

public class DeleteTaskByIdUseCase
{
    public void Execute(int id, List<TaskType> tasks)
    {
        var task = tasks.Find(task => task.Id == id)!;

       tasks.Remove(task);

    }
}
