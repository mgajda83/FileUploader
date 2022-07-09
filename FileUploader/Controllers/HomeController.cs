using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.Extensions.Localization;

namespace FileUploader.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;
        public HomeController(IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            ViewData["AppName"] = _localizer["AppName"];
            ViewData["UploadPhotos"] = _localizer["UploadPhotos"];
            ViewData["ImageThumbnails"] = _localizer["ImageThumbnails"];
            ViewData["Privacy"] = _localizer["Privacy"];
            ViewData["DropFiles"] = _localizer["DropFiles"];
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
