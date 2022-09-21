using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZodiacSign_App.Models;
using Application.ViewModel;
using Application.Services;

namespace ZodiacSign_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ZodiacSignService _zodiacSignService;

        public HomeController()
        {
            _zodiacSignService = new ZodiacSignService();
        }

        public IActionResult Index()
        {
            return View(_zodiacSignService.GetAll());
        }

        [HttpPost]
        public IActionResult GetSign(ZodiacSignCreateViewModel vm)
        {
            _zodiacSignService.Add(vm);
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}