using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreRegSite.Models;
using CoreRegSite.Interfaces;
using Microsoft.AspNetCore.Routing;

namespace CoreRegSite.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Participant> participantRepo;

        public HomeController(IRepository<Participant> partRepo){
            this.participantRepo = partRepo;
        }
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
            IEnumerable<Participant> parts = participantRepo.GetAll();
            foreach(Participant p in parts)
            {
                if(p.ParticipantEmail == model.Email){
                    ModelState.AddModelError("Email", "Этот email уже используется");
                    return PartialView("RegistrationForm", model);
                }
            }

            Participant newUser = new Participant
            {
                ParticipantEmail = model.Email,
                ParticipantFirstName = model.FirstName,
                ParticipantSecondName = model.SecondName,
                ParticipantPhone = model.Phone,
                ParticipantActivity = model.Activity
            };
            participantRepo.Add(newUser);
            participantRepo.SaveChanges();
            using ( var context = new CityFestContext())
            {
                var users = await context.Participants.AsNoTracking().ToListAsync();
                return Content("<script>window.location='/Home/GetParticipants'</script>");
            }
        }

        public async Task<IActionResult> GetParticipants()
        {
            using ( var context = new CityFestContext())
            {
                var allUsers = await context.Participants.AsNoTracking().ToListAsync();
                return View(allUsers);
            }
        }
    }
}
