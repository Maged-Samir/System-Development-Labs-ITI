using ITI.Revision.WebAPI.Models;

namespace ITI.Revision.WebAPI.DTO.Course
{
    public record CourseCreateDTO(
        string Name,
        string Description,
        Level Level);
}
