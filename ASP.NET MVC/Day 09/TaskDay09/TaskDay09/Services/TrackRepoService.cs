using Microsoft.EntityFrameworkCore;
using TaskDay09.Models;

namespace TaskDay09.Services
{
    public class TrackRepoService : ITrackRepository
    {

        private readonly ApplicationDbContext context;
        public TrackRepoService(ApplicationDbContext context)
        {
            this.context=context;
        }


        public void Delete(int id)
        {
            context.Remove(context.Tracks.Find(id));
            context.SaveChanges();
        }

        public List<Track> GetAll()
        {
            return context.Tracks.ToList();
        }

        public Track GetById(int id)
        {
            return context.Tracks.Find(id);
        }

        public void Insert(Track track)
        {
            context.Tracks.Add(track);
            context.SaveChanges();
        }

        public void Update(int id, Track track)
        {
            Track UpdatedTrack = context.Tracks.Find(id);
            UpdatedTrack.Name= track.Name;
            UpdatedTrack.Description= track.Description;
            UpdatedTrack.Trainees= track.Trainees;

            context.SaveChanges();

        }
    }
}
