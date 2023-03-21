using TaskDay09.Models;

namespace TaskDay09.Services
{
    public interface ICourseRepository
    {
        public List<Course> GetAll();
        public Course GetById(int id);
        public void Insert(Course course);
        public void Update(int id, Course course);
        public void Delete(int id);
    }
}
