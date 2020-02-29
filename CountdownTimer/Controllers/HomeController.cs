using CountdownTimer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CountdownTimer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TimerViewModel model = new TimerViewModel();          
            TempData["EndTime"] = Session["EndTime"];           
            return View(model);
        }

        [HttpPost]
        public void PostCountdownTimer(TimerViewModel model)
        {
            if (Session["EndTime"] == null)
            {
                Session["EndTime"] = DateTime.Now.AddHours(model.Hour).AddMinutes(model.Minute).AddSeconds(model.Second).ToString("dd-MM-yyyy h:mm:ss tt");
            }
            TempData["EndTime"] = Session["EndTime"];
            Response.Redirect("/Home/Index");
        }

        // Destroys EndTime Session object
        public void StopTimer()
        {
            Session.Abandon();
        }


    }
}