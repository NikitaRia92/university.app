using Microsoft.AspNetCore.Mvc;
using University.Domain.Models;
using University.Services.ConfirmationEnrollments.Create;
using University.Services.ConfirmationEnrollments.Delete;
using University.Services.ConfirmationEnrollments.GetList;
using University.Services.ConfirmationEnrollments.Update;

namespace University.App.Controllers;

public class ConfirmationEnrollmentController : ApiController
{
    [HttpPost]
    public async Task<ActionResult<ConfirmationEnrollment>> Create(CreateConfirmationEnrollmentCommand
        command,CancellationToken token)
    {   //метод на получение записи из Statement где false
        //Прокидываются нужные значения из Statement с false в эту модель
        //Вручную дописываются нужные поля
        // если запись создается нормально то апдейтится запись из Statement на true
        var response = await Mediator.Send(command, token);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<ConfirmationEnrollment>>> GetList(CancellationToken token)
    {
        var response = await Mediator.Send(new GetListConfirmationEnrollmentQuery(), token);
        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult<ConfirmationEnrollment>> Update([FromBody] UpdateConfirmationEnrollmentCommand
        command, CancellationToken token)
    {
        var response = await Mediator.Send(command, token);
        return Ok(response);
    }


    [HttpDelete]
    public async Task<ActionResult> Delete([FromBody] DeleteConfirmationEnrollmentCommand command, CancellationToken token)
    {
        var response = await Mediator.Send(command, token);
        return Ok(response);
    }

}
