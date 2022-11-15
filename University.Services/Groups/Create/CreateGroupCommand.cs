using MediatR;
using University.Domain.Models;

namespace University.Services.Groups.Create;

public record CreateGroupCommand(int GroupNumber, int CourceNumber, string FacultyCode
    , string SpecialtyCode) : IRequest<Group>
{

}
