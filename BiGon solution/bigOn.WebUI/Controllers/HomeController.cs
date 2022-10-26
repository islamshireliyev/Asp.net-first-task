using bigOn.WebUI.AppCode.Extensions;
using bigOn.WebUI.Models.DataContexts;
using bigOn.WebUI.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;

namespace bigOn.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly BigOnDbContext db;
        private readonly IConfiguration configuration;


        public HomeController(BigOnDbContext db, IConfiguration configuration)
        {
            this.db = db;
            this.configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactPost model)
        {
            if (ModelState.IsValid)
            {
                db.ContactPosts.Add(model);
                db.SaveChanges();
                //ViewBag.Message = "Muracietinzi qeyde alindi.Tezlikle geri donus edeceyik";
                //ModelState.Clear();
                //return View();
                var response = new
                {
                    error = false,
                    message = "Muracietinzi qeyde alindi.Tezlikle geri donus edeceyik",
                    state = ModelState.GetErrors()
                };
                return Json(response);
            }
            var responseError = new
            {
                error = true,
                message = "Melumat uygun deyil deuzelish edin...",
                state = ModelState
            };
            return Json(responseError);
        }
        public IActionResult Faq()
        {
            var data = db.Faqs.Where(f => f.DeletedDate == null).ToList();
            return View(data);
        }

        
    }
}
