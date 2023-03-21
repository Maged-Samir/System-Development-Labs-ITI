using TaskDay09.Models;

namespace TaskDay09.Services
{
    public interface ITraineeRepository
    {
        public List<Trainee> GetAll();
        public Trainee GetById(int id);
        public void Insert(Trainee track);
        public void Update(int id, Trainee track);
        public void Delete(int id);
    }
}
