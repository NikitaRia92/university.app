using MediatR;
using University.Domain.Models;

namespace University.Services.FormedGroups.Create;

public record CreateFormedGroupCommand(int RegistryNumber, string FacultyCode, string SpecialtyCode,
        int GroupNumber, int NumberOfStudentsInAGroup ) : IRequest<FormedGroup>
{

}
