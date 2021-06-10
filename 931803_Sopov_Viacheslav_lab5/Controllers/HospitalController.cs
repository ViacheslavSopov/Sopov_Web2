using Microsoft.AspNetCore.Mvc;
using Lab5.Models;

namespace Lab5.Controllers
{
    public class HospitalController : Controller
    {

        HospitalContext db;
        public HospitalController(HospitalContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.hospitals);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Hospital h) 
        {
            if (ModelState.IsValid)
            {
                db.Add(h);
                db.SaveChanges();
                ViewBag.SuccessMessage = "Recorded";
            }
            return View();
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id != null)
                return View(db.hospitals.Find(id));
            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Hospital h)
        {
            if (ModelState.IsValid)
            {
                db.hospitals.Update(h);
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
                Hospital h =  db.hospitals.Find(id);
                if (h!=null)
                    return View(h);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult  Delete(int? id)
        {
            if (id != null)
            {
                Hospital h = db.hospitals.Find(id);
                db.hospitals.Remove(h);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        public IActionResult Details(int? id)
        {
            if (id != null)
            {
                Hospital h = db.hospitals.Find(id);
                if (h != null)
                    return View(h);
            }
            return NotFound();
        }
    }
}
