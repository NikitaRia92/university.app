using Microsoft.AspNetCore.Mvc;
using University.Domain.Models;
using University.Services.ExcelFileProcessing;
using University.Services.Statements.AddFromFile;
using University.Services.Statements.Create;
using University.Services.Statements.Delete;
using University.Services.Statements.GetList;
using University.Services.Statements.Update;

namespace University.App.Controllers;

public class StatementController : ApiController
{
    [HttpPost]
    public async Task<ActionResult<Statement>> Create([FromBody] CreateStatementCommand command, CancellationToken token)
    {
        var response = await Mediator.Send(command, token);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<Statement>>> GetList(CancellationToken token)
    {
        var response = await Mediator.Send(new GetListStatementQuery(), token);
        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult<Statement>> Update([FromBody] UpdateStatementCommand command, CancellationToken token)
    {
        var response = await Mediator.Send(command, token);
        return Ok(response);
    }

    [HttpPut("AddList")]

    public async Task<ActionResult<IReadOnlyCollection<InvalidRowModel>>> Import(IFormFile file,  CancellationToken token)
    {
        var response = await Mediator.Send(new AddListStatementCommand(file), token);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<ActionResult> Delete([FromBody] DeleteStatementCommand command, CancellationToken token)
    {
        var response = await Mediator.Send(command, token);
        return Ok(response);
    }
}
