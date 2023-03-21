using TaskDay09.Models;

namespace TaskDay09.Services
{
    public interface ITrackRepository
    {
        public List<Track> GetAll();
        public Track GetById(int id);
        public void Insert(Track track);
        public void Update(int id,Track track);
        public void Delete(int id);
    }
}
