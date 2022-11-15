using MediatR;
using University.Domain.Models;

namespace University.Services.Groups.Update;

public record UpdateGroupCommand(int Id, int GroupNumber, int CourceNumber, string FacultyCode
    , string SpecialtyCode) : IRequest<Group>
{

}
