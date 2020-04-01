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
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace CoreRegSite.Controllers
{
    public class AdminController : Controller
    {
        IRepository<Participant> participantRepo;
        private readonly IMapper mapper;
        const int Users_per_page = 5;
        public AdminController(IRepository<Participant> _repo, IMapper _mapper)
        {
            this.participantRepo = _repo;
            this.mapper = _mapper;
        }
        [HttpGet]
        public IActionResult LogIn(){
            var model = new AdminModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(AdminModel model)
        {
            if(!ModelState.IsValid) return View();

            if (model.Login == "admin" && model.Password == "admin")
            {
                // создаем один claim
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "Admin")
                };
                // создаем объект ClaimsIdentity
                ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
                // установка аутентификационных куки
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));

                return Redirect("/Admin/GetUsers");
            }
            ModelState.AddModelError("", "Invalid email or password");
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Admin");
        }
        [Authorize]
        public IActionResult GetUsers(int id = 1)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)participantRepo.GetCount() / Users_per_page);
            ViewBag.CurrentPageNumber = id;

            int process = (Users_per_page * id * 100) / participantRepo.GetCount();
            if(process > 100){
                ViewBag.ProcessNow = 100;
            }else ViewBag.ProcessNow = process;
            
            var users = participantRepo.GetAll()
                                        .ToList()
                                         .Skip((id - 1) * Users_per_page)
                                          .Take(Users_per_page);

            var mappedUsers = mapper.Map<IEnumerable<Participant>, List<UserModel>>(users);
            return View(mappedUsers);
        }
        public IActionResult Delete(int id = 0)
        {
                Participant user = participantRepo.Get(id);
                if(user != null)
                {
                    participantRepo.Delete(user);
                    participantRepo.SaveChanges();
                }
                return RedirectToAction("GetUsers");
        }
    }
}