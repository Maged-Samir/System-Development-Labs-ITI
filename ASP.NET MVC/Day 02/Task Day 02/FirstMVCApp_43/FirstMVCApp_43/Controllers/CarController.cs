﻿using FirstMVCApp_43.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCApp_43.Models;
using System.Web.Razor.Generator;

namespace FirstMVCApp_43.Controllers
{
    public class CarController : Controller
    {
        
        public ActionResult getAll()
        {
            List<Car> carLst = CarList.cars;

            ViewBag.Cars = carLst;

            return View();
        }

        public ActionResult getById(int id)
        {
            ViewBag.selectedCar = CarList.cars.FirstOrDefault(e => e.Id == id);

            return View();
        }

        public ActionResult Edit(int id)
        {
            ViewBag.selectedCar = CarList.cars.FirstOrDefault(e => e.Id == id);

            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, string model, string color, string manfacture,string img)
        {
            Car edidtedCar = CarList.cars.FirstOrDefault(e => e.Id == id);

            edidtedCar.Model = model;
            edidtedCar.Color = color;
            edidtedCar.Manfacture = manfacture;
            edidtedCar.Img = img;

            return RedirectToAction("getAll");
        }

        public ActionResult delete(int id)
        {
            var deletedCar = CarList.cars.FirstOrDefault(e => e.Id == id);
            CarList.cars.Remove(deletedCar);
            return RedirectToAction("getAll");
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(int id, string model, string color, string manfacture,string img)
        {
            Car carcar =new Car();

            carcar.Id= id;
            carcar.Model = model;
            carcar.Color = color;
            carcar.Manfacture = manfacture;
            carcar.Img = img;

            CarList.cars.Add(carcar);

            return RedirectToAction("getAll");

        }


    }
}