using Microsoft.AspNetCore.Mvc;
using Lab5.Models;

namespace Lab5.Controllers
{
    public class PatientController : Controller
    {

        HospitalContext db;
        public PatientController(HospitalContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.patients);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Patient p) 
        {
            if (ModelState.IsValid)
            {
                db.Add(p);
                db.SaveChanges();
                ViewBag.SuccessMessage = "Recorded";
            }
            return View();
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id != null)
                return View(db.patients.Find(id));
            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Patient p)
        {
            if (ModelState.IsValid)
            {
                db.patients.Update(p);
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
                Patient p =  db.patients.Find(id);
                if (p!=null)
                    return View(p);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult  Delete(int? id)
        {
            if (id != null)
            {
                Patient p = db.patients.Find(id);
                db.patients.Remove(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        public IActionResult Details(int? id)
        {
            if (id != null)
            {
                Patient p= db.patients.Find(id);
                if (p != null)
                    return View(p);
            }
            return NotFound();
        }
    }
}
