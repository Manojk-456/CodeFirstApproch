using CodeFirstApproch.Db_Context;
using CodeFirstApproch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproch.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDataContext _db;
        public HomeController(AppDataContext db)
        {
            _db = db;
        }

       

        public IActionResult Index()
        {
            var res = _db.students.ToList();
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
