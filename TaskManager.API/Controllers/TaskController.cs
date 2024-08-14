using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Task.Create;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreatedTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestTaskJson request)
    {
        var createTaskuseCase = new CreateTaskUseCase();

        createTaskuseCase.Execute(request);

        return Created();
    }



}
