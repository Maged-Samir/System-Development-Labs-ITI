using SharedLibrary;

namespace TaskOfBlazor.Services
{
    public interface ITraineeDataService
    {
        Task<IEnumerable<Trainee>> GetAllTrainees();
        Task<Trainee> GetTraineeDetails(int traineeId);
        Task AddTrainee(Trainee trainee);
        Task UpdateTrainee(Trainee trainee);
        Task DeleteTrainee(int traineeId);
    }
}
