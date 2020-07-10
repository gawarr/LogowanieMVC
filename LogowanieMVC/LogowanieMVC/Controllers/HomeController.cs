using LogowanieMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogowanieMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            LogIn.EnterData();
            ViewBag.Login = LogIn.login;

            return View();
        
        }
    }
}