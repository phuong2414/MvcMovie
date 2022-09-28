using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    // GET: /HelloWorld/
    public class HelloWorldController : Controller
    {
        Movie[] movieList = new Movie[]{
            new Movie
                    (
                        1,
                        "When Harry Met Sally",
                        DateTime.Parse("1989-2-12"),
                        "Romantic Comedy",
                        "7.99M"
                    ),

                    new Movie
                    (
                        2,
                        "Ghostbusters ",
                        DateTime.Parse("1984-3-13"),
                        "Comedy",
                        "8.99M"
                    ),

                    new Movie
                    (
                        3,
                        "Ghostbusters 2",
                        DateTime.Parse("1986-2-23"),
                        "Comedy",
                        "9.99M"
                    ),
                    new Movie
                    (
                        4,
                        "Rio Bravo",
                        DateTime.Parse("1959-4-15"),
                        "Western",
                        "3.99M"
                    )
                    };

        public string Index()
        {
            return "This is my default action...";
        }

        // GET: /HelloWorld/List/ 
        public IActionResult List()
        {
            ViewData["movies"] = this.movieList;
            return View();
        }

        // GET: /HelloWorld/Detail/
        public IActionResult Detail(int id)
        {
            ViewData["movie"] = this.movieList[id - 1];
            return View();
        }

        public IActionResult ChartJS()
        {
            return View();
        }
    }
}