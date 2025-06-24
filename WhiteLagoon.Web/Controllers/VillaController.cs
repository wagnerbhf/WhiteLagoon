using Microsoft.AspNetCore.Mvc;
using WhiteLagoon.Application.Common.Interfaces;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly IUnityOfWork _unitOfWork;

        public VillaController(IUnityOfWork unitOfWork) => _unitOfWork = unitOfWork;

        public IActionResult Index()
        {
            var villas = _unitOfWork.Villa.GetAll();
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
                _unitOfWork.Villa.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Villa has been created successfully.";
                return RedirectToAction(nameof(Index)); 
            }

            TempData["error"] = "The villa could not be created.";
            return View(obj);
        }

        public IActionResult Update(int villaId)
        {
            Villa obj = _unitOfWork.Villa.Get(u => u.Id == villaId);

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
                _unitOfWork.Villa.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Villa has been updated successfully.";
                return RedirectToAction(nameof(Index));
            }

            TempData["error"] = "The villa could not be updated.";
            return View(obj);
        }

        public IActionResult Delete(int villaId)
        {
            Villa obj = _unitOfWork.Villa.Get(u => u.Id == villaId);

            if (obj is null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(Villa obj)
        {
            Villa villaFromDb = _unitOfWork.Villa.Get(u => u.Id == obj.Id);

            if (villaFromDb is not null)
            {
                _unitOfWork.Villa.Remove(villaFromDb);
                _unitOfWork.Save();
                TempData["success"] = "Villa has been deleted successfully.";
                return RedirectToAction(nameof(Index));
            }

            TempData["error"] = "The villa could not be deleted.";
            return View();
        }
    }
}