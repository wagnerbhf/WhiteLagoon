using Microsoft.AspNetCore.Mvc;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly ApplicationDbContext _db;

        public VillaController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var villas = _db.Villas.ToList();
            return View(villas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Villa obj)
        {
            if (obj.Name == obj.Description)
            {
                ModelState.AddModelError("name", "The Name cannot exactly match the Description.");
            }

            if (ModelState.IsValid)
            {
                _db.Villas.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Villa has been created successfully.";
                return RedirectToAction(nameof(Index)); 
            }

            TempData["error"] = "The villa could not be created.";
            return View(obj);
        }

        public IActionResult Update(int villaId)
        {
            Villa obj = _db.Villas.FirstOrDefault(u => u.Id == villaId);

            if (obj == null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult Update(Villa obj)
        {
            if (ModelState.IsValid && obj.Id > 0)
            {
                _db.Villas.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Villa has been updated successfully.";
                return RedirectToAction(nameof(Index));
            }

            TempData["error"] = "The villa could not be updated.";
            return View(obj);
        }

        public IActionResult Delete(int villaId)
        {
            Villa obj = _db.Villas.FirstOrDefault(u => u.Id == villaId);

            if (obj is null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(Villa obj)
        {
            Villa villaFromDb = _db.Villas.FirstOrDefault(u => u.Id == obj.Id);

            if (villaFromDb is not null)
            {
                _db.Villas.Remove(villaFromDb);
                _db.SaveChanges();
                TempData["success"] = "Villa has been deleted successfully.";
                return RedirectToAction(nameof(Index));
            }

            TempData["error"] = "The villa could not be deleted.";
            return View();
        }
    }
}