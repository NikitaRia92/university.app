using MediatR;
using University.Domain.Enums;
using University.Domain.Models;

namespace University.Services.Specialities.Update;

public record UpdateSpecialityCommand(string Code, string ShortName, string Name, int MinimumPassingScore
    , LevelsOfStudyAtTheUniversity LevelsOfStudyAtTheUniversity, int Price, int NumberOfFreeSeats
    , int NumberOfSeats) : IRequest<Speciality>
{

}
