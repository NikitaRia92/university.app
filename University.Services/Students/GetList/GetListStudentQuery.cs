using MediatR;
using University.Domain.Models;

namespace University.Services.Students.GetList;

public record GetListStudentQuery : IRequest<IReadOnlyCollection<Student>>
{
}
