using Microsoft.AspNetCore.Mvc;
using Lab5.Models;

namespace Lab5.Controllers
{
    public class LabController : Controller
    {

        HospitalContext db;
        public LabController(HospitalContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.labs);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Lab l) 
        {
            if (ModelState.IsValid)
            {
                db.Add(l);
                db.SaveChanges();
                ViewBag.SuccessMessage = "Recorded";
            }
            return View();
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id != null)
                return View(db.labs.Find(id));
            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Lab l)
        {
            if (ModelState.IsValid)
            {
                db.labs.Update(l);
                db.SaveChanges();
                ViewBag.SuccessMessage = "Edited";
            }
            return View();
        }

        [HttpGet]
        [ActionName("Delete")]
        public  IActionResult ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Lab l =  db.labs.Find(id);
                if (l!=null)
                    return View(l);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult  Delete(int? id)
        {
            if (id != null)
            {
                Lab l = db.labs.Find(id);
                db.labs.Remove(l);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        public IActionResult Details(int? id)
        {
            if (id != null)
            {
               Lab l= db.labs.Find(id);
                if (l != null)
                    return View(l);
            }
            return NotFound();
        }
    }
}
