using Microsoft.AspNetCore.Mvc;
using University.Domain.Models;
using University.Services.FormedGroups.Create;
using University.Services.FormedGroups.Delete;
using University.Services.FormedGroups.GetList;
using University.Services.FormedGroups.Update;

namespace University.App.Controllers;

public class FormedGroupController : ApiController
{
    [HttpPost]
    public async Task<ActionResult<FormedGroup>> Create([FromBody] CreateFormedGroupCommand command
        , CancellationToken token)
    {
        var response = await Mediator.Send(command, token);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<FormedGroup>>> GetList(CancellationToken token)
    {
        var response = await Mediator.Send(new GetListFormedGroupQuery(), token);
        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult<FormedGroup>> Update([FromBody] UpdateFormedGroupCommand command
        , CancellationToken token)
    {
        var response = await Mediator.Send(command, token);
        return Ok(response);

    }

    [HttpDelete]
    public async Task<ActionResult> Delete([FromBody] DeleteFormedGroupCommand command, CancellationToken token)
    {
        var response = await Mediator.Send(command, token);
        return Ok(response);
    }
}
