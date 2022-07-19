using EPC.Core.Models.Cars;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EPC.Controllers
{
    public class CarsController : BaseController
    {

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddCarFormModel car)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
