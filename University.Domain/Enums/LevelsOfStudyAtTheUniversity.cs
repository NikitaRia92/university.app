using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace University.Domain.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LevelsOfStudyAtTheUniversity
    {
        Specialty = 'S',
        Undergraduate = 2,
        Magistracy = 3,
        Postgraduate_Study =4
    }
}
