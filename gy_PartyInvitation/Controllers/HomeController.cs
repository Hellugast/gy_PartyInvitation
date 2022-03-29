using gy_PartyInvitation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace gy_PartyInvitation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Participant participant)
        {
            if (ModelState.IsValid)
            {
                if (participant.Participation == true)
                {
                    ViewBag.Message = "Hazırlıklar başlasın!";
                    return View("Thanks");
                }
                else
                {
                    ViewBag.Message = "Bir dahaki sefere bekleriz";
                    return View("Thanks");
                }
            }
            return View();
        }



    }
}
