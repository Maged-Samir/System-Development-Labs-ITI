using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TaskDayTwo.Models;

namespace TaskDayTwo.Controllers
{

    public class TitleController : Controller
    {

        pubsEntities context=new pubsEntities();

        // GET: Title

        
        public ActionResult Index(string searchString)
        {
            var titles = from m in context.titles
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                titles = context.titles.Where(s => s.type.Contains(searchString));
            }

            ViewBag.Publishers = context.publishers.ToList();

            return View(titles);
        }

       


        // GET: Title/Details/5
        public ActionResult Details(string id)
        {
            
            return View(context.titles.FirstOrDefault(t => t.title_id == id));
        }

        // GET: Title/Create
        public ActionResult Create()
        {
            ViewBag.Publishers = context.publishers.ToList();
            return View();
        }

        // POST: Title/Create
        [HttpPost]
        public ActionResult Create(title t)
        {
            try
            {
                // TODO: Add insert logic here

                var c = new title
                {
                    title1=t.title1,
                    title_id=t.title_id,
                    type=t.type,
                    price=t.price,
                    advance=t.advance,  
                    notes=t.notes,
                    pubdate=t.pubdate,
                    publisher = t.publisher,
                    pub_id = t.pub_id,
                    royalty = t.royalty,
                    ytd_sales = t.ytd_sales 

                };

              

                context.titles.Add(c);

                context.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Title/Edit/5
        public ActionResult Edit(string id)
        {
            title t = context.titles.Find(id);
            ViewBag.Publishers = context.publishers.ToList();

            return View(t);
        }

        // POST: Title/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here


                title t = context.titles.Find(id);
                t.title1 = collection["title1"];
                t.price =decimal.Parse( collection["price"]);
                t.notes = collection["notes"];
                t.pub_id = collection["pub_id"];
                t.pubdate =DateTime.Parse( collection["pubdate"]);
                t.advance = decimal.Parse(collection["advance"]);
                t.royalty =int.Parse( collection["royalty"]);
                t.ytd_sales = int.Parse(collection["ytd_sales"]);
                t.type = collection["type"];

                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Title/Delete/5
        public ActionResult Delete(string id)
        {
            
                title t = context.titles.Find(id);
                context.titles.Remove(t);
                context.SaveChanges();
                return RedirectToAction("Index");
            
            
        }

    }
}
