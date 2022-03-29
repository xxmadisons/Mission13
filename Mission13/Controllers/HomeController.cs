using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission13.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13.Controllers
{
    public class HomeController : Controller
    {
        private IBowlersRepository _repo { get; set; }

        //private ITeamsRepository _yuh { get; set; }

        //Constructor
        public HomeController(IBowlersRepository temp)
        {
            _repo = temp;
        }

        //public HomeController(ITeamsRepository temp2)
       // {
           // _yuh = temp2;
        //}

        public IActionResult Index()
        {

            var blah = _repo.Bowlers.ToList();
            //var blah2 = _yuh.Teams.ToList();

            return View(blah);
        }

        
    }
}
