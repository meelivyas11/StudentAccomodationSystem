using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentAccommodationSystem.Models;
using StudentAccommodationSystem.ViewModel;
using AutoMapper;

namespace StudentAccommodationSystem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("LandingPage");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel user)
        {
            //connect to DB and verify the credentials
            if(user!=null && user.UserName == "admin" && user.Password == "admin")
            {
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return RedirectToAction("Index", "User"); 
            }
         }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            //connect to DB - insert values as pending
            //return View("SuccessfulRegistration");
            UserModel b = Mapper.Map<UserModel>(model);
            


            return RedirectToAction("Index", "User");
        }

       
    }
}