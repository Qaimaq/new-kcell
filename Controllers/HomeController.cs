using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KCell_Solutions.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;

namespace KCell_Solutions.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;
        public HomeController(IStringLocalizer<HomeController> localizer,
                   IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _localizer = localizer;
            _sharedLocalizer = sharedLocalizer;
        }
       public string Test()
        {
            // получаем ресурс Message
            string message = _sharedLocalizer["Message"];
            return message;


        }
        
        // остальное содержимое контроллера
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Contacts()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Career()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Software()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult SMS_Dispatching()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Car_Tracking()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }

    }
}
