using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentAccommodationSystem.Models;

namespace StudentAccommodationSystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View("AdminHomePage");
        }

        public ActionResult PendingAdvertisements()
        {
            List<RoomModel> roomList = new List<RoomModel>  { new RoomModel ("Female Roomates Needed", "Nice clean Room", "Lexington,KY", 56, "http://www.bedroomchecker.com/wp-content/uploads/2013/12/Standard-Room1-300x145.png"),
                                                        new RoomModel("Boys house", "Shared room with two double beds", "Lexington, KY", 57, "http://www.bwhotelcappellodoro-bg.it/resources/images/9fa01f0e-3aa7-44ba-ac95-e33b367ef274/en/B/business-room.jpg") ,
                                                        new RoomModel("Need female roomate to share QualityInn room", "Two Twin size beds", "Lexington,KY", 58, "http://www.travelchinaguide.com/images/photogallery/2010/standard-room.jpg"),
                                                        new RoomModel("Need Roomies ASAP", "Really nice room to stay", "Lexington,KY", 60, "http://farm3.static.flickr.com/2734/4309891294_371be0a5d3.jpg") };
            ViewBag.MyList = roomList;
            foreach (var r in roomList)
                r.Status = "Pending";
            return View();
        }

        public ActionResult ViewNewUsers()
        {
            List<UserModel> newUserList = new List<UserModel> {  new UserModel ("meevyas", "meelivyas@my.a.com"),
                                                       new UserModel ("ankit", "ankit@my.a.com"),
                                                       new UserModel ("saket", "saket@a.com"),
                                                       new UserModel ("addi", "asdfg@a.com") };
            foreach(UserModel u in newUserList)
            {
                u.Status = "Pending";
            }
            ViewBag.NewUserList = newUserList;
            return View();
        }
    }
}