using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreRegSite.Models;

namespace CoreRegSite.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegistrationForm(UserModel model)
        {
            if(!ModelState.IsValid){
                return PartialView("RegistrationForm");
            }
            // model = null;
            // return PartialView("GetParticipants");
            using ( var context = new CityFestContext())
            {
                var users = await context.Participants.AsNoTracking().ToListAsync();
                return PartialView("GetParticipants", users);
            }
        }

        public async Task<IActionResult> GetParticipants()
        {
            using ( var context = new CityFestContext())
            {
                var model = await context.Participants.AsNoTracking().ToListAsync();
                return PartialView("GetParticipants");
            }
        }
    }
}
