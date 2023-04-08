using APIs.Day1.Filters;
using Day01.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Day01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }


        //GetAllCars
        [HttpGet]
        public ActionResult<List<Car>> GetAll()
        {
            _logger.LogCritical("Test Logging When GetAllCars");
            return Ok(Car.Cars.ToList());
        }

        //GetById
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Car> GetById(int id)
        {
            var car = Car.Cars.FirstOrDefault(c => c.Id == id);
            if (car is null)
            {
                return NotFound();
            }

            return Ok(car);
        }

        //Create Version 01
        [HttpPost]
        [Route("v1")]
        public ActionResult Add(Car car)
        {
            car.Id = new Random().Next(10, 1000);
            car.Type = "Gas";
            Car.Cars.Add(car);
            return CreatedAtAction(
                actionName: nameof(GetById),
                routeValues: new { id = car.Id },
                value: new { Message = "your Car has been Added Successfully !" });
        }

        //Create Version 02
        [HttpPost]
        [Route("v2")]
        [ServiceFilter(typeof(ValidateCarTypeAttribute))]
        public ActionResult Addv2(Car car)
        {
            car.Id = new Random().Next(10, 1000);
            car.Type = "Gas";
            Car.Cars.Add(car);
            return CreatedAtAction(
                actionName: nameof(GetById),
                routeValues: new { id = car.Id },
                value: new { Message = "your Car has been Added Successfully !" });
        }


        //UpdateCar
        [HttpPut]
        [Route("{id}")]
        public ActionResult Update(int id,Car car)
        {
            if (id != car.Id)
            {
                return BadRequest();
            }

            var UpdateCar = Car.Cars.FirstOrDefault(c => c.Id == id);
            if (UpdateCar is null)
            {
                return NotFound();
            }

            
            UpdateCar.Price = car.Price;
            UpdateCar.Model = car.Model;
            UpdateCar.ProductionDate=car.ProductionDate;

            return NoContent();
        }

        //DeleteCar
        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteById(int id)
        {
            var DeletedCar = Car.Cars.FirstOrDefault(c => c.Id == id);
            if (DeletedCar is null)
            {
                return NotFound();
            }
            Car.Cars.Remove(DeletedCar);
            return NoContent();
        }



    }
}
