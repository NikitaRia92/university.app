using Microsoft.AspNetCore.Mvc;
using University.Domain.Models;
using University.Services.Groups.Create;
using University.Services.Groups.Delete;
using University.Services.Groups.GetList;
using University.Services.Groups.Update;

namespace University.App.Controllers;

public class GroupController : ApiController
{
    [HttpPost]
    public async Task<ActionResult<Group>> Create([FromBody] CreateGroupCommand createGroupQuery, CancellationToken token)
    {
        var response = await Mediator.Send(createGroupQuery, token);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<Group>>> GetList(CancellationToken token)
    {
        var response = await Mediator.Send(new GetListGroupQuery(), token);
        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult<Group>> Update([FromBody] UpdateGroupCommand command, CancellationToken token)
    {
        var response = await Mediator.Send(command, token);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<ActionResult> Delete([FromBody] DeleteGroupCommand command, CancellationToken token)
    {
        var response = await Mediator.Send(command, token);
        return Ok(response);
    }
}
