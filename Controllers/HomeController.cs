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
using System.Net.Mail;
using System.Net;
using AutoMapper;

namespace CoreRegSite.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Participant> participantRepo;
        private readonly IMapper mapper;

        public HomeController(IRepository<Participant> partRepo, IMapper _mapper){
            this.participantRepo = partRepo;
            this.mapper = _mapper;
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
                if(p.ParticipantEmail == model.ParticipantEmail){
                    ModelState.AddModelError("Email", "Этот email уже используется");
                    return PartialView("RegistrationForm", model);
                }
            }
            var mappedUser = mapper.Map<Participant>(model);
            participantRepo.Add(mappedUser);
            participantRepo.SaveChanges();

           var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("natasha.cat982404@gmail.com", "************"),
                EnableSsl = true
            };
            await client.SendMailAsync("natasha.cat982404@gmail.com", model.ParticipantEmail, "Благодарим за регистрацию", "Ваша заявка будет рассмотрена в ближайшее время)");

            using ( var context = new CityFestContext())
            {
                return Content("<script>window.location='/Home/GetParticipants'</script>");
            }
        }

        public async Task<IActionResult> GetParticipants()
        {
            using ( var context = new CityFestContext())
            {
                var allUsers = await context.Participants.AsNoTracking().ToListAsync();
                var mappedUsers = mapper.Map<List<Participant>, List<SimpleUserModel>>(allUsers);
                return View(mappedUsers);
            }
        }
    }
}
