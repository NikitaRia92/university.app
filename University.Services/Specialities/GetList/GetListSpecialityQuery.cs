using MediatR;
using University.Domain.Models;

namespace University.Services.Specialities.GetList;

public record GetListSpecialityQuery : IRequest<IReadOnlyCollection<Speciality>>
{
}
