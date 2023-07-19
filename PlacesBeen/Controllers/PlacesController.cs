using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;
using System.Collections.Generic;

namespace PlacesBeen.Controllers
{
    public class PlacesController : Controller
    {
        [HttpGet("/places")]
        public ActionResult Index()
        {
            List<Place> allPlaces = Place.GetAll();
            return View(allPlaces);
        }

        [HttpGet("/places/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/places")]
        public ActionResult Create(string city, string country, string journal)
        {
            Place myplace = new Place(city, country, journal);
            return RedirectToAction("Index");
        }

        [HttpGet("/places/{id}")]
        public ActionResult Show(int id)
        {
            Place foundItem = Place.Find(id);
            return View(foundItem);
        }

        [HttpPost("/places/delete")]
        public ActionResult DeletePlace(int id)
        {
            Place.Delete(id);
            return View();
        }
    }
}
