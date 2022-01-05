using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            string todaysDate = DateTime.Now.ToShortDateString();

            return Ok("You have entered id = " + id + "\r\non\r\n" + todaysDate);
        }
    }
}
