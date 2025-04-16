using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Limitless_Gym.Controllers
{
    public class GymController : Controller
    {
        // GET: Gym
        public ActionResult Index()
        {
            return View();
        }
    }
}