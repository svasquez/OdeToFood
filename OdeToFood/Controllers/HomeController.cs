using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController  : Controller
    {
        public IActionResult Index()
        {
            var model = new Restaurant { Id=1, Name="Smill's Pizza Palace" };
            return new ObjectResult(model);
        }
    }
}
