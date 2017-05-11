using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel.Models.ViewModels;

namespace ViewModel.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Logon()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Logon(LogonViewModel pageData)
        {
            if (pageData.Account == "skill" &&
            pageData.PassWord == "tree")
            {
                pageData.Message =
                $"成功。";
                ViewData["class_name"] = "warning";
            }
            else
            {
                pageData.Message =
                $"失敗。";
                ViewData["class_name"] = "danger";
            }
            return View(pageData);
        }
    }
}