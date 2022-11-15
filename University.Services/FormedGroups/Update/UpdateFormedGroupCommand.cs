using MediatR;
using University.Domain.Models;

namespace University.Services.FormedGroups.Update
{
    public record UpdateFormedGroupCommand (int RegistryNumber, string FacultyCode, string SpecialtyCode
        , int GroupNumber, int NumberOfStudentsInAGroup) : IRequest<FormedGroup>
    {
    }
}
