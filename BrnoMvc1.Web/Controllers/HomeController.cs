using BrnoMvc1.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrnoMvc1.Web.Controllers
{
    public class HomeController : Controller
    {
        public IEmailService LoggingService { get; set; }

        public HomeController(IEmailService loggingService)
        {
            this.LoggingService = loggingService;
        }

        public ActionResult Index()
        {
            if (true)
            {
                this.TempData["ErrorMessage"] = "Errooooor";
                return RedirectToAction("About");
            }


            string model = "Hello";
            //this.LoggingService.Log("Hello from logging service");
            return View(model: model);
        }

        public ActionResult About()
        {

            //this.TempData["Key"] = "Value from Home About";

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.AhojSvete = "AhojSvete.";

            return View();
        }
    }
}