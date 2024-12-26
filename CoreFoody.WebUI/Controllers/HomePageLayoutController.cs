using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.Controllers;
public class HomePageLayoutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}