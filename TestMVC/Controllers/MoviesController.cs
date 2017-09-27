using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Finding Dory" };

            var viewResult = new ViewResult();

            return View(movie);
        }
        [Route("movies/released/{year}/{month:regex(\\d{4:range(1,12)})}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);

        }

        
    }   
 

}