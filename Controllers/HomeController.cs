using Assignment_6_Joisah_Sarles.Models;
using Assignment_6_Joisah_Sarles.Models.ViewModels;
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
        public int PageSize = 5;

        // recieves the logger and the repository then sets the private values
        public HomeController(ILogger<HomeController> logger, IFamazonRepo repo)
        {
            _logger = logger;
            _repo = repo;
        }

        // sends the _repo.books to the view to be used to print on the index page
        public IActionResult Index(int page = 1)
        {

            //UPdate the new to include the booklistviewmodel
            return View(new BookListViewModel
            {
                Books = _repo.books
                    .OrderBy(p => p.bookId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize)
                    ,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = _repo.books.Count()
                }
            });

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
