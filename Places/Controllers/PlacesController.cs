using Microsoft.AspNetCore.Mvc;
using Travel.Models;
using System.Collections.Generic;

namespace Travel.Controllers
{
  public class PlacesController : Controller
  {

    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Places> allPlaces = Places.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName, string date, string journal, string companion)
    {
      Places myPlaces = new Places(cityName, date, journal, companion);
      return RedirectToAction("Index");
    }
    // [HttpPost("/items/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Places.ClearAll();
    //   return View();
    // }
    //
    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Places places = Places.Find(id);
      return View(places);
    }
  }
}
