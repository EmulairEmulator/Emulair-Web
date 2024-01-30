using EmulairWEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CollectiHaven.Controllers
{
    public class FAQController : Controller
    {

        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Hello()
        {

            return Ok("Alex");
        }
    }
}