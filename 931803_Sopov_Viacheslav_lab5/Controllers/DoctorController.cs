using Microsoft.AspNetCore.Mvc;
using Lab5.Models;

namespace Lab5.Controllers
{
    public class DoctorController : Controller
    {

        HospitalContext db;
        public DoctorController(HospitalContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.doctors);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Doctor d) 
        {
            if (ModelState.IsValid)
            {
                db.Add(d);
                db.SaveChanges();
                ViewBag.SuccessMessage = "Recorded";
            }
            return View();
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id != null)
                return View(db.doctors.Find(id));
            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Doctor d)
        {
            if (ModelState.IsValid)
            {
                db.doctors.Update(d);
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
                Doctor d =  db.doctors.Find(id);
                if (d!=null)
                    return View(d);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult  Delete(int? id)
        {
            if (id != null)
            {
                Doctor d = db.doctors.Find(id);
                db.doctors.Remove(d);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        public IActionResult Details(int? id)
        {
            if (id != null)
            {
                Doctor d= db.doctors.Find(id);
                if (d != null)
                    return View(d);
            }
            return NotFound();
        }
    }
}
