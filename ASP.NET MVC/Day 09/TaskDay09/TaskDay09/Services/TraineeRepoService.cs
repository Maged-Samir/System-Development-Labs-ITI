using TaskDay09.Models;

namespace TaskDay09.Services
{
    public class TraineeRepoService : ITraineeRepository
    {
        private readonly ApplicationDbContext context;
        public TraineeRepoService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            context.Remove(context.Trainees.Find(id));
            context.SaveChanges();
        }

        public List<Trainee> GetAll()
        {
            return context.Trainees.ToList();
        }

        public Trainee GetById(int id)
        {
            return context.Trainees.Find(id);
        }

        public void Insert(Trainee trainee)
        {
            context.Trainees.Add(trainee);
            context.SaveChanges();
        }

        public void Update(int id, Trainee trainee)
        {
            Trainee UpdatedTrainee = context.Trainees.Find(id);
            UpdatedTrainee.Name = trainee.Name;
            UpdatedTrainee.Email = trainee.Email;
            UpdatedTrainee.ConfirmEmail = trainee.ConfirmEmail;
            UpdatedTrainee.gender = trainee.gender;
            UpdatedTrainee.PhoneNumber = trainee.PhoneNumber;
            UpdatedTrainee.BirthDate = trainee.BirthDate;
            UpdatedTrainee.TrackID = trainee.TrackID;


            context.SaveChanges();
        }
    }
}
