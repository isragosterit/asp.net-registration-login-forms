using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_project.Models;
using static System.Net.Mime.MediaTypeNames;

namespace web_project.Controllers
{
    public class LoginController : Controller
    {
        DbModels dbModel = new DbModels();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User log)
        {
            var user = dbModel.User.Where(x => x.email == log.email && x.password == log.password).Count();
            if (user > 0)
            {
                ViewBag.SuccessMessage = "Login is successfull.";
                return View();
            }
            else
            {
                ViewBag.DuplicateMessage = "Check your e-mail or password!";
                return View();
            }

        }
    }
}