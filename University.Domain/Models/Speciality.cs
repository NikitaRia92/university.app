using University.Domain.Enums;

namespace University.Domain.Models;

public class Speciality
{
    public string Code { get; set; }
    public string ShortName { get; set; }
    public string Name { get; set; }
    public LevelsOfStudyAtTheUniversity LevelsOfStudyAtTheUniversity { get; set; }

    public int MinimumPassingScore { get; set; }
    public int Price { get; set; }
    public int NumberOfFreeSeats { get; set; }
    public int NumberOfSeats { get; set; }

}
