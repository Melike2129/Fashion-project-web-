using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using faskion.Models;


namespace faskion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            

            return View();
        }
        [HttpGet]
        public ActionResult Contact()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Contact(form fsh)
        {
            if (ModelState.IsValid)
            {
                ViewBag.name = fsh.Name;
                ViewBag.surname = fsh.SurName;
                ViewBag.email = fsh.Email;
                ViewBag.confirmEmail = fsh.EmailConfirm;

                ViewBag.phone = fsh.Phone;
                ViewBag.gender = fsh.Gender;

                return View("Result", fsh);
            }
            else { return View(); }

        }
        public ActionResult Login()
        {


            return View();
        }

        public ActionResult Capsule()
        {
            

            return View();
        }
        public ActionResult NewIn()
        {
      

            return View();
        }

        public ActionResult Gift()
        {
            

            return View();
        }

        public ActionResult Result(form info)
        {
            if (ModelState.IsValid)
                return View(info);
            else
                return View("Contact");
        }

        

    }
}