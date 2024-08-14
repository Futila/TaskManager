using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Task.Create;
using TaskManager.Application.UseCases.Task.GetById;
using TaskManager.Communication.Entities;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{

    public static List<TaskType> Tasks { get; set; } = [];

    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreatedTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestTaskJson request)
    {
        var createTaskuseCase = new CreateTaskUseCase();

        createTaskuseCase.Execute(request, Tasks);

        return Created();
    }


    [HttpGet]
    [ProducesResponseType(typeof(ResponseCreatedTaskJson), StatusCodes.Status200OK)]
    public IActionResult GetAll ()
    {
        return Ok(Tasks);

    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult GetById(int id) 
    { 
        var getTaskByIdUseCase = new GetTaskByIdUseCase();

        var response = getTaskByIdUseCase.Execute(id, Tasks);
    
        return Ok(response);
    }



}
