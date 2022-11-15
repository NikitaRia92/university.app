using MediatR;
using University.Domain.Models;

namespace University.Services.Faculties.Update
{
    public record UpdateFacultyCommand(string Code, string ShortName, string Name) : IRequest<Faculty>
    {
    }
}
