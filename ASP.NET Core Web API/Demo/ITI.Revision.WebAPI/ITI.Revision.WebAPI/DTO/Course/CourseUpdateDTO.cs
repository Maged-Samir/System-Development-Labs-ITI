using ITI.Revision.WebAPI.Models;

namespace ITI.Revision.WebAPI.DTO.Course
{
    public record CourseUpdateDTO(
        int Id,
        string Name,
        string Description,
        Level Level);
}
