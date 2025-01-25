using FileUploader.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FileUploader.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IStringLocalizer<HomeController> _localizer;
        public HomeController(IStringLocalizer<HomeController> localizer, ILogger<HomeController> logger, IConfiguration configuration)
        {
            _localizer = localizer;
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewData["AppName"] = _localizer["AppName"];
            ViewData["UploadPhotos"] = _localizer["UploadPhotos"];
            ViewData["ImageThumbnails"] = _localizer["ImageThumbnails"];
            ViewData["Privacy"] = _localizer["Privacy"];
            ViewData["DropFiles"] = _localizer["DropFiles"];
            ViewData["HomeTab"] = _localizer["HomeTab"];
            ViewData["PrivacyTab"] = _localizer["PrivacyTab"];
            ViewData["Welcome"] = _localizer["Welcome"];
            ViewData["SignIn"] = _localizer["SignIn"];
            ViewData["SignOut"] = _localizer["SignOut"];
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Privacy"] = _localizer["Privacy"];
            ViewData["HomeTab"] = _localizer["HomeTab"];
            ViewData["PrivacyTab"] = _localizer["PrivacyTab"];
            ViewData["Welcome"] = _localizer["Welcome"];
            ViewData["SignIn"] = _localizer["SignIn"];
            ViewData["SignOut"] = _localizer["SignOut"];
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
