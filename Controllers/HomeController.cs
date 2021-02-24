using Assignment_6_Joisah_Sarles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6_Joisah_Sarles.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //Added a private repository
        private IFamazonRepo _repo;
        public int ItemsPerPage = 5;

        // recieves the logger and the repository then sets the private values
        public HomeController(ILogger<HomeController> logger, IFamazonRepo repo)
        {
            _logger = logger;
            _repo = repo;
        }

        // sends the _repo.books to the view to be used to print on the index page
        public IActionResult Index(int page = 1)
        {
            return View(_repo.books
                .OrderBy(p => p.bookId)
                .Skip((page - 1) * ItemsPerPage)
                .Take(ItemsPerPage)
                );
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
