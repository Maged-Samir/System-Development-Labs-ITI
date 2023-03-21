using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskDay09.Models;
using TaskDay09.Services;

namespace TaskDay09.Controllers
{
    public class TraineeController : Controller
    {

        public ITraineeRepository TraineeRepository { get; }
        public ITrackRepository TrackRepository { get; }
        public TraineeController(ITraineeRepository traineeRepository,ITrackRepository trackRepository)
        {
              TraineeRepository = traineeRepository;
              TrackRepository = trackRepository;
        }


        // GET: TraineeController
        public ActionResult Index()
        {
            ViewBag.MYTracks = TrackRepository.GetAll();
            return View(TraineeRepository.GetAll());
        }

        // GET: TraineeController/Details/5
        public ActionResult Details(int id)
        {
            return View(TraineeRepository.GetById(id));
        }

        // GET: TraineeController/Create
        public ActionResult Create()
        {
            ViewBag.MYTracks = TrackRepository.GetAll();
            return View();
        }

        // POST: TraineeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Trainee trainee)
        {
            try
            {
                TraineeRepository.Insert(trainee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TraineeController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.MYTracks = TrackRepository.GetAll();
            return View(TraineeRepository.GetById(id));
        }

        // POST: TraineeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Trainee trainee)
        {
            try
            {
                TraineeRepository.Update(id, trainee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TraineeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(TraineeRepository.GetById(id));
        }

        // POST: TraineeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Trainee trainee)
        {
            try
            {
                TraineeRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
