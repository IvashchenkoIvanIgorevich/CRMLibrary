using AutoMapper;
using CRMLibrary.Services.HomeService;
using CRMLibrary.Services.RegisterService;
using CRMLibrary.UI.Models;
using DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace CRMLibrary.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService _serviceBook;
        private readonly IUserService _serviceUser;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IBookService serviceBook, IUserService serviceUser, ILogger<HomeController> logger)
        {
            _serviceBook = serviceBook;
            _serviceUser = serviceUser;
            _logger = logger;
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
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserViewModel>());
            //var mapper = new Mapper(config);
            //var users = mapper.Map<List<UserViewModel>>(_serviceUser.GetAll());

            //ViewBag.Users = (List<UserViewModel>)users;

            return View();
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            if (_serviceBook.GetById(id) == null)
            {
                return NotFound();
            }

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Book, BookViewModel>());
            var mapper = new Mapper(config);
            var book = mapper.Map<BookViewModel>(_serviceBook.GetById(id));

            return View(book);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edit(BookViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var config = new MapperConfiguration(cfg => cfg.CreateMap<BookViewModel, Book>());
            var mapper = new Mapper(config);
            var book = mapper.Map<Book>(model);            

            var editModel = _serviceBook.GetById(model.Id);
            editModel.Name = model.Name;
            editModel.Author = model.Author;
            editModel.IsAvailable = model.IsAvailable;
            editModel.Location = model.Location;
            editModel.Pages = model.Pages;
            editModel.PublishedYear = model.PublishedYear;
            editModel.Redaction = model.Redaction;
            editModel.Summary = model.Summary;
            
            _serviceBook.Edit(editModel);

            if (model.Id > 0)
            {
                _logger.LogInformation("Edited book with id = {0}.", model.Id);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [Authorize]
        public IActionResult Look(BookViewModel bookViewModel)
        {
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
