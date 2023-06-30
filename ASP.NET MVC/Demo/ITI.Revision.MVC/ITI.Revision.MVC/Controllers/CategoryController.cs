using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITI.Revision.MVC.Data;
using ITI.Revision.MVC.Models;
using ITI.Revision.MVC.Services;
using Microsoft.AspNetCore.Authorization;
using ITI.Revision.MVC.Filters;

namespace ITI.Revision.MVC.Controllers
{
    //[Authorize]
    [ServiceFilter(typeof(ExecutionTimeFilter))]
    public class CategoryController : Controller
    {
        ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }



        // GET: Category
        public  IActionResult Index()
        {
              return categoryService.GetAllCategories() != null ? 
                          View(categoryService.GetAllCategories().ToList()) :
                          Problem("Entity set 'ITIRevisionMVCContext.Category'  is null.");
        }

        // GET: Category/Details/5
        public IActionResult Details(int id)
        {
            if (id == null || categoryService.GetAllCategories() == null)
            {
                return NotFound();
            }

            var category = categoryService.GetCategoryById(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Category/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create([Bind("Id,Name,ClassLevel")] Category category)
        {
            if (ModelState.IsValid)
            {
                categoryService.AddNewCategory(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

       
    }
}
