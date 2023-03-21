using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskDay09.Models;
using TaskDay09.Services;

namespace TaskDay09.Controllers
{
    public class CourseController : Controller
    {
        public ICourseRepository CourseRepository { get; }
        public ITraineeRepository TraineeRepository { get; }

        public CourseController(ICourseRepository courseRepository, ITraineeRepository traineeRepository)
        {
            CourseRepository = courseRepository;
            TraineeRepository = traineeRepository;
        }


        // GET: CourseController
        public ActionResult Index()
        {
            ViewBag.Trainees = TraineeRepository.GetAll();
            return View(CourseRepository.GetAll());
        }

        // GET: CourseController/Details/5
        public ActionResult Details(int id)
        {
            return View(CourseRepository.GetById(id));
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            ViewBag.Trainees = TraineeRepository.GetAll();
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course course)
        {
            try
            {
                CourseRepository.Insert(course);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(CourseRepository.GetById(id));
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Course course)
        {
            try
            {
                CourseRepository.Update(id, course);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(CourseRepository.GetById(id));
        }

        // POST: CourseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Course course)
        {
            try
            {
                CourseRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
