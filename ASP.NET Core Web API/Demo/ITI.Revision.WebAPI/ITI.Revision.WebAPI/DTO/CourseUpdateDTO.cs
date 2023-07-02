using ITI.Revision.WebAPI.Models;

namespace ITI.Revision.WebAPI.DTO
{
    public record CourseUpdateDTO(
        int Id,
        string Name,
        string Description,
        Level Level);
}
