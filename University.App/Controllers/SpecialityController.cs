using Microsoft.AspNetCore.Mvc;
using University.Domain.Models;
using University.Services.Specialities.Create;
using University.Services.Specialities.Delete;
using University.Services.Specialities.GetList;
using University.Services.Specialities.Update;

namespace University.App.Controllers;

public class SpecialityController : ApiController
{
    [HttpPost]
    public async Task<ActionResult<Speciality>> Create([FromBody] CreateSpecialityCommand command, CancellationToken token)
    {
        var response = await Mediator.Send(command, token);
        return Ok(response);
    }
    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<Speciality>>> GetList(CancellationToken token)
    {
        var response = await Mediator.Send(new GetListSpecialityQuery(), token);
        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult<Speciality>> Update([FromBody] UpdateSpecialityCommand command
        , CancellationToken token)
    {
        var response = await Mediator.Send(command, token);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<ActionResult> Delete([FromBody] DeleteSpecialityCommand command, CancellationToken token)
    {
        var response =  await Mediator.Send(command, token);
        return Ok(response);
    }
}
