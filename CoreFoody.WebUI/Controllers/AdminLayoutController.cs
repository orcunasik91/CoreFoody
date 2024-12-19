using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.Controllers;
public class AdminLayoutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}