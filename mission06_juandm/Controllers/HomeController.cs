using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mission06_juandm.Models;
using System.Diagnostics;
using System.Linq;

namespace mission06_juandm.Controllers
{
    public class HomeController : Controller
    {
       
        // making new constructor to help connect to db
        private MovieInfoContext daContext { get; set; }


        //constructor and adding to it so it can save to db 
        public HomeController( MovieInfoContext tempName)
        {
            daContext = tempName;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult addForm()
        {
            ViewBag.Categories = daContext.Categories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult addForm(ApplicationResponse ar)
        {
            //adding the object and saving changes through context file!!!
            if (ModelState.IsValid)
            {
                daContext.Add(ar);
                daContext.SaveChanges();

               return View("Confirmation", ar);

            }
            //if form is not valid do this...
            else
            {
                ViewBag.Categories = daContext.Categories.ToList();
                return View(ar);
            }
            
        }
        // podcast page
        public IActionResult Podcast()
        {
            return View();
        }
        
        public IActionResult ReadTable()
        {
            var applications = daContext.Responses
                .Include(x =>x.Category)
                .OrderBy(x => x.Year)
                .ToList();

            return View(applications);
        }
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = daContext.Categories.ToList();

            // grabbing a specific movie in this case, by movieid
            var movie = daContext.Responses.Single(x => x.MovieID == movieid);

            return View("addForm", movie);
        }
        [HttpPost]
        public IActionResult Edit (ApplicationResponse ar1)
        {

            daContext.Update(ar1);
            daContext.SaveChanges();

            return RedirectToAction("ReadTable");
        }
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = daContext.Responses.Single(x => x.MovieID == movieid);

            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            
            daContext.Responses.Remove(ar);
            daContext.SaveChanges();
            return RedirectToAction("ReadTable");
        }
    }
}
