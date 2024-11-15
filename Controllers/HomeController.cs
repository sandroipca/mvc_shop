using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_shop.Models;

namespace mvc_shop.Controllers;

public class HomeController : Controller{

    public IActionResult Index()
    {
        return View();
    }
}
