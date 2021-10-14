using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalProject.WEBUI.Model;
using HospitalProject.WEBUI.Infastructure;
using HospitalProject.WEBUI.Data;
using HospitalProject.WEBUI.Service;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace HospitalProject.WEBUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser user;
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(UserCreateModel u)
        {
            this.user.Insert(u);
            this.user.save();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(UserCreateModel uu,string username,string password)
        {
            if(!string.IsNullOrEmpty(uu.UserName) && string.IsNullOrEmpty(uu.Password))
            {
                return RedirectToAction("Login");
            }
            ClaimsIdentity identity = null;
            bool isAuthenticate = false;
            if (uu.UserName=="admin" && uu.Password=="a1234")
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim (ClaimTypes.Name,uu.UserName),
                    new Claim(ClaimTypes.Role,"Admin")
                },CookieAuthenticationDefaults.AuthenticationScheme);
                isAuthenticate = true;
            }
            if (uu.UserName == "demo" && uu.Password == "a12345678")
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim (ClaimTypes.Name,uu.UserName),
                    new Claim(ClaimTypes.Role,"User")
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                isAuthenticate = true;
            }
            if (isAuthenticate)
            {
                var principal = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,principal);
                return RedirectToAction("Index", "Home");
            }
                        return RedirectToAction("Index", "Home");
        }
        
    }
}
