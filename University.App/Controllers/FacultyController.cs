using Microsoft.AspNetCore.Mvc;
using University.Domain.Models;
using University.Services.Faculties.Create;
using University.Services.Faculties.Delete;
using University.Services.Faculties.GetList;
using University.Services.Faculties.Update;

namespace University.App.Controllers;

public class FacultyController : ApiController
{
    [HttpPost]
    public async Task<ActionResult<Faculty>> Create([FromBody] CreateFacultyCommand createFacultyQuery, CancellationToken token)
    {
        var response = await Mediator.Send(createFacultyQuery, token);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<Faculty>>> GetList(CancellationToken token)
    {

        var response = await Mediator.Send(new GetListFacultyQuery(), token);
        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult<Faculty>> Update([FromBody] UpdateFacultyCommand command, CancellationToken token)
    {
        var response = await Mediator.Send(command, token);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<ActionResult>Delete([FromBody] DeleteFacultyCommand deleteFacultyCommand, CancellationToken token)
    {
        var response = await Mediator.Send(deleteFacultyCommand, token);
        return Ok(response);
    }
}
