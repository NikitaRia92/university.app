using Microsoft.AspNetCore.Mvc;
using University.Domain.Models;
using University.Services.Students.Create;
using University.Services.Students.Delete;
using University.Services.Students.GetList;
using University.Services.Students.Update;

namespace University.App.Controllers;

public class StudentController : ApiController
{
    [HttpPost]
    public async Task<ActionResult<Student>> Create([FromBody] CreateStudentCommand command, CancellationToken token)
    {
        var response = await Mediator.Send(command, token);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<Student>>> GetList(CancellationToken token)
    {
        var response = await Mediator.Send(new GetListStudentQuery(), token);
        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult<Student>> Update([FromBody] UpdateStudentCommand command, CancellationToken token)
    {
        var response = await Mediator.Send(command, token);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<ActionResult> Delete([FromBody] DeleteStudentCommand command, CancellationToken token)
    {
        var response = await Mediator.Send(command, token);
        return Ok(response);
    }
}
