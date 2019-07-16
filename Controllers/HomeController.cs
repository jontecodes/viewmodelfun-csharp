using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewmodel.Models;

namespace viewmodel.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            string message = "This is a message of a message inside of another message but where is the damn message?";
            return View("index", message);
        }
        //
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
                1, 2, 3, 10, 43, 5
            };
            return View("numbers", numbers);
        }
        //
        [HttpGet("users")]
        public IActionResult Users()
        {
            User thisUser = new User(){
                FirstName="Jonte",
                LastName="Rufus"
            };
            User thatUser = new User()
            {
                FirstName="Keith",
                LastName="Lahori"
            };
            List<User> Hello = new List<User>()
            {
                thisUser, thatUser
            };
            return View("users", Hello);
        }
        //
        [HttpGet("user")]
        public IActionResult User()
        {
            User thisUser = new User(){
                FirstName="Jonte",
                LastName="Rufus"
            };
            return View("user", thisUser);
        }

    }
}
