using Microsoft.AspNetCore.Mvc;

namespace CoreFoody.WebUI.Controllers;
public class ErrorPagesController : Controller
{
    public IActionResult ErrorPage404()
    {
        return View();
    }
}