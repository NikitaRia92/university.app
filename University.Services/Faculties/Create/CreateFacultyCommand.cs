using MediatR;
using University.Domain.Models;

namespace University.Services.Faculties.Create;

public record CreateFacultyCommand(string Code, string ShortName, string Name) : IRequest<Faculty>
{

}
