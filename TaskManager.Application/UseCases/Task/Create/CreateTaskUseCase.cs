
using TaskManager.Communication.Entities;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.Create;

public class CreateTaskUseCase
{
    public static int nextId = 1;
    public ResponseCreatedTaskJson Execute(RequestTaskJson request, List<TaskType> tasks)
    {

        var newTask = new TaskType
        {
            Id= nextId++,
            Name = request.Name,
            Deadline = request.Deadline,
            Description = request.Description,
            Priority = request.Priority,
            Status = request.Status,
        };
       

        tasks.Add(newTask);

        return new ResponseCreatedTaskJson
        {
            Id = newTask.Id,
            Name = newTask.Name,
        };
    }
}
