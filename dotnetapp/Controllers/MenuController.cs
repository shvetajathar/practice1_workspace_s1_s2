using Microsoft.AspNetCore.Mvc;
namespace dotnetapp.Controllers;
public class MenuController : Controller
{
    [HttpGet]
    [Route("menu/home")]
    public IActionResult Home()
    {
        return View();
    }
    [HttpGet]
    [Route("menu/customers")]
    public IActionResult Customers()
    {
        return View();
    }
    [HttpGet]
    [Route("menu/products")]

    public IActionResult Products()
    {
        return View();
    }
    [HttpGet]
    [Route("menu/orders")]
    public IActionResult Orders()
    {
        return View();
    }
}
