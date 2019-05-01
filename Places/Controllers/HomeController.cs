using Microsoft.AspNetCore.Mvc;

namespace Travel.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}
