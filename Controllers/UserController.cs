using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_project.Controllers;
using web_project.Models;

namespace web_project.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult AddOrEdit(int id = 0)
        {
            User userModel = new User();
            return View(userModel);
        }

        [HttpPost]
        public ActionResult AddOrEdit(User userModel)
        {
            using (DbModels dbModel = new DbModels())
            {
                if (dbModel.User.Any(x => x.email == userModel.email))
                {
                    ViewBag.DuplicateMessage = "E-mail already exists.";
                    return View("AddOrEdit", userModel);
                }
                dbModel.User.Add(userModel);
                dbModel.SaveChanges();
            }

            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful.";
            return View("AddOrEdit", new User());
        }
    }
}