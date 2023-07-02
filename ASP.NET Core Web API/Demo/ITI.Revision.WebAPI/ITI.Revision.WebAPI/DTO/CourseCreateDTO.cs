using ITI.Revision.WebAPI.Models;

namespace ITI.Revision.WebAPI.DTO
{
    public record CourseCreateDTO(
        string Name,
        string Description,
        Level Level);
}
