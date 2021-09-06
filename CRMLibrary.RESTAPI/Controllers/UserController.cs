using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CRMLibrary.RESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        LibraryContext db = new LibraryContext();

        [HttpGet]        
        public ActionResult<IEnumerable<User>> Index() => db.User.ToList();
    }
}