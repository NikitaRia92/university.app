using MediatR;
using University.Domain.Models;

namespace University.Services.Faculties.GetList;

public record GetListFacultyQuery : IRequest<IReadOnlyCollection<Faculty>>
{

}
