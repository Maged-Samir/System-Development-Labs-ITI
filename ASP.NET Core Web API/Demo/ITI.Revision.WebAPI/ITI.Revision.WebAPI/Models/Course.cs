namespace ITI.Revision.WebAPI.Models
{
    public enum Level
    {
        One, Two, Three
    }
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Level Level { get; set; }

        public List<Student>? Students { get; set; } = new();
    }
}
