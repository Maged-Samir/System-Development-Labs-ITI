namespace ITI.Revision.WebAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int NationalId { get; set; }
        public string Location { get; set; }

        public List<Course>? Courses { get; set; } = new();

    }
}
