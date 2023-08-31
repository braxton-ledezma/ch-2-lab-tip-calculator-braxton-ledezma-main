using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ch2Lab.Models;

namespace Ch2Lab.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(new TipCalculator());
    }

    [HttpPost]
    public IActionResult Index(TipCalculator tipCalculator)
    {
        if(ModelState.IsValid)
        {
            tipCalculator.CalculateTips();
        }
        else
        {
            tipCalculator = new TipCalculator();
        }
        tipCalculator.CalculateTips();
        return View(tipCalculator);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
