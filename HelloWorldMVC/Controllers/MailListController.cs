using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorldMVC.Models;

namespace HelloWorldMVC.Controllers
{
    public class MailListController : Controller
    {
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult SignUp(RegisterViewModel mem)
        {
            if (ModelState.IsValid)
            {
                Member m = new Member()
                {
                    Email = mem.Email
                };
                MemberDB.RegisterMember(m);
                return RedirectToAction("Index", "Home");
            }
            return View(mem);
        }
    }
}