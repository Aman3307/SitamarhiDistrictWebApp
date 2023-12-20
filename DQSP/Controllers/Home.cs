using DQSP.Models;
using DQSP.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DQSP.Controllers
{
    public class HomeController : Controller
    {
        private readonly DistrictQueryRepository _repository;

        public HomeController(DistrictQueryRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult Submit(DistrictQueryModel districtQuery)
        {
            if (ModelState.IsValid)
            {
                districtQuery.CreatedAt = DateTime.Now;
                _repository.SaveDistrictQuery(districtQuery);
            }

            return RedirectToAction("Index", "Home");
        }

    }
}
