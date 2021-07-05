using AutoMapper;
using CRMLibrary.Services.HomeService;
using CRMLibrary.Services.RegisterService;
using CRMLibrary.UI.Models;
using DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace CRMLibrary.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService _serviceBook;
        private readonly IUserService _serviceUser;

        public HomeController(IBookService serviceBook, IUserService serviceUser)
        {
            _serviceBook = serviceBook;
            _serviceUser = serviceUser;
        }

        public IActionResult Index()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Book, BookViewModel>());
            
            var mapper = new Mapper(config);
            
            var books = mapper.Map<List<BookViewModel>>(_serviceBook.GetAll());
            return View(books);
        }

        [Route("userinfo")]
        [Authorize]
        public IActionResult UserInformation()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserViewModel>());

            var mapper = new Mapper(config);

            var users = mapper.Map<List<UserViewModel>>(_serviceUser.GetAll());
            ViewBag.Users = (List<UserViewModel>)users;
            return View();
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
