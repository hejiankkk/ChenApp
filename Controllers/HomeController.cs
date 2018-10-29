using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChenApp.Models;
using ChenApp.Services;

namespace ChenApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserInfoService _userInfoService;

        public HomeController(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }

        public IActionResult Index()
        {
            ViewBag.User = _userInfoService.GetUserInfo();
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
