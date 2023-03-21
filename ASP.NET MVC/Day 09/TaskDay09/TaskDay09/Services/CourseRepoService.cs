using TaskDay09.Models;

namespace TaskDay09.Services
{
    public class CourseRepoService : ICourseRepository
    {
        private readonly ApplicationDbContext context;
        public CourseRepoService(ApplicationDbContext context)
        {
            this.context = context;
        }


        public void Delete(int id)
        {
            context.Remove(context.Courses.Find(id));
            context.SaveChanges();
        }

        public List<Course> GetAll()
        {
            return context.Courses.ToList();
        }

        public Course GetById(int id)
        {
            return context.Courses.Find(id);
        }

        public void Insert(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
        }

        public void Update(int id, Course course)
        {
            Course UpdatedCourse = context.Courses.Find(id);

            UpdatedCourse.Topic = course.Topic;
            UpdatedCourse.Grade = course.Grade;
            UpdatedCourse.TraineeID = course.TraineeID;

            context.SaveChanges();
        }
    }
}
