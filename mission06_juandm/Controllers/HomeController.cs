using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission06_juandm.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_juandm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // making new constructor to help connect to db
        private MovieInfoContext _starterContext { get; set; }


        //constructor and adding to it so it can save to db 
        public HomeController(ILogger<HomeController> logger, MovieInfoContext tempName)
        {
            _logger = logger;
            _starterContext = tempName;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult addForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addForm(ApplicationResponse ar)
        {
            //adding the object and saving changes through context file!!!
            _starterContext.Add(ar);
            _starterContext.SaveChanges();

            return View("Confirmation", ar);
        }
        // podcast page
        public IActionResult Podcast()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
