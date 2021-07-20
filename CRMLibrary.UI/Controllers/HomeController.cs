using AutoMapper;
using CRMLibrary.Services.HomeService;
using CRMLibrary.UI.Models;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace CRMLibrary.UI.Controllers
{
    public class HomeController : Controller
    {
        private IBookService _service;

        public HomeController(IBookService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Book, BookViewModel>());
            
            var mapper = new Mapper(config);
            
            var books = mapper.Map<List<BookViewModel>>(_service.GetAllBooks());
            return View(books);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
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
