using SharedLibrary;
using System.Net.Http.Json;

namespace TaskOfBlazor.Services
{
    public class TraineeDataService : ITraineeDataService
    {
        public HttpClient HttpClient { get; }
        public TraineeDataService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task AddTrainee(Trainee trainee)
        {
            await HttpClient.PostAsJsonAsync<Trainee>("/api/Trainees/", trainee);
        }

        public async Task DeleteTrainee(int traineeId)
        {
            await HttpClient.DeleteAsync("/api/Trainees/" + traineeId);
        }

        public async Task<IEnumerable<Trainee>> GetAllTrainees()
        {
            return await HttpClient.GetFromJsonAsync<IEnumerable<Trainee>>("/api/Trainees");
        }

        public async Task<Trainee> GetTraineeDetails(int traineeId)
        {
            return await HttpClient.GetFromJsonAsync<Trainee>("/api/Trainees/" + traineeId);
        }

        public async Task UpdateTrainee(Trainee trainee)
        {
            await HttpClient.PutAsJsonAsync("/api/Trainees/" + trainee.Id, trainee);
        }
       
    }
}
