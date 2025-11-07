using Microsoft.AspNetCore.Mvc;

namespace DotnetBlog.Website.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;


    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [Route("")]
    public IActionResult Index()
    {
        return View("~/Views/Home/Home.cshtml");
    }
}
