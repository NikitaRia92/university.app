using MediatR;
using University.Domain.Enums;
using University.Domain.Models;

namespace University.Services.Specialities.Create;

public record CreateSpecialityCommand(string Code, string ShortName, string Name
        , LevelsOfStudyAtTheUniversity LevelsOfStudyAtTheUniversity, int MinimumPassingScore
        , int Price, int NumberOfFreeSeats, int NumberOfSeats) : IRequest<Speciality>

{

}
