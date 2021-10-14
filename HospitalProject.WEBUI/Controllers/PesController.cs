using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalProject.WEBUI.Model;
using HospitalProject.WEBUI.Data;
using HospitalProject.WEBUI.Service;
using HospitalProject.WEBUI.Infastructure;
using Microsoft.AspNetCore.Authorization;

namespace HospitalProject.WEBUI.Controllers
{
    public class PesController : Controller
    {
        private readonly ISpecimenanddiseaseinformation spe;

        public PesController(ISpecimenanddiseaseinformation p)
        {
            this.spe = p;
        }
        [HttpGet]
        [Authorize(Roles = "Admin,User")]
        public IActionResult Index()
        {
            var Specimenan = this.spe.GetAll();
            return View(Specimenan);
        }
        public IActionResult Add()
        {

            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Add(Specimenanddiseaseinformation p)
        {
            this.spe.Insert(p);
            this.spe.save();
            return View();
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int Id)
        {
            var pes = this.spe;
            return View(pes);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(Specimenanddiseaseinformation pp)
        {
            this.spe.Delete(pp);
            this.spe.save();
            return View(pp);
        }

    }
}
