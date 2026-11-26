// GolBet.Web/Controllers/ErrorController.cs
using Microsoft.AspNetCore.Mvc;

namespace GolBet.Web.Controllers;

public class ErrorController : Controller
{
    // Re-executed by UseStatusCodePagesWithReExecute("/Error/{0}")
    [Route("Error/{statusCode:int}")]
    public IActionResult Handle(int statusCode)
    {
        if (statusCode == 404)
            return View("NotFound");

        return View("General");
    }

    // Target of UseExceptionHandler (unhandled exceptions = 500)
    [Route("Error/General")]
    public IActionResult General()
        => View("General");
}
