using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubGamified.Controllers
{
    public class GithubUserController : Controller
    {

        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }
    }
}
