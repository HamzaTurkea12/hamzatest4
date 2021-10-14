using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalProject.WEBUI.Model;
using HospitalProject.WEBUI.Data;
using HospitalProject.WEBUI.Service;
using HospitalProject.WEBUI.Infastructure;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace HospitalProject.WEBUI.Controllers
{
    public class HomeController : Controller
    {

        [Authorize(Roles ="Admin,User")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
