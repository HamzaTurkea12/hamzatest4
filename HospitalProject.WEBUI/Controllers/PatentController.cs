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
    public class PatentController : Controller
    {
        private readonly IPatentInformation patent;

        public PatentController(IPatentInformation patent)
        {
            this.patent = patent;
        }
        [HttpGet]
        [Authorize(Roles = "Admin,User")]
        public IActionResult Index()
        {
            var patents = this.patent.GetAll();
           
            return View(patents);
        }
        [HttpGet]
        public IActionResult Add()
        {
           
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Add(PatentInformation patent)
        {
            this.patent.Insert(patent);
            this.patent.save();
            return View();
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int Id)
        {
            var patent = this.patent;
            return View(patent);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(PatentInformation pp)
        {
            this.patent.Delete(pp);
            this.patent.save();
            return View(pp);
        }


    }
}
