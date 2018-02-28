using DrJasmine.DAL;
using DrJasmine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrJasmine.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Appointment()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Submit(User user)
        {
            if (ModelState.IsValid)
            {
                UserDal dal = new UserDal();               
                user.InquiryDate = DateTime.Now;
                user.InquiryTime = DateTime.Now;
                dal.user.Add(user);
                dal.SaveChanges();

                return View(user);
            }
            else
            {
                return View("Home");
            }         
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Blog1()
        {
            return View();
        }

        public ActionResult Blog2()
        {
            return View();
        }

    }

}