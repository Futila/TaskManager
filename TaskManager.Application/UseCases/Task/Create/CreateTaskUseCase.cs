
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.Create;

public class CreateTaskUseCase
{
    public ResponseCreatedTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseCreatedTaskJson
        {
            Id = 1,
            Name = request.Name,
        };
    }
}
