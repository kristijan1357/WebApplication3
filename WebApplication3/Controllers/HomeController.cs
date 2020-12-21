using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public List<Animal> Animals { get; set; }
        /*Komentar ostaven od Nikola Vasilevski */
        public HomeController()
        {
            Animals = new List<Animal>()
            {
                new Animal(1, "Emilija", 5),
                new Animal(2, "Kristina", 7),
                new Animal(3, "Stefan", 3),
                new Animal(4, "Sara", 9)

            };
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(Animals);
        }

        [HttpPost]
        public ActionResult Index(string newAnimalName, int newAnimalAge)
        {
            Animals.Add(new Animal(5, newAnimalName, newAnimalAge));
            return View(Animals);
        }


        [HttpPost]
        public ActionResult Delete(string animalToDelete)
        {
            Animal animal = Animals.FirstOrDefault(x => x.Name.Equals(animalToDelete));
            Animals.Remove(animal);
            return View("Index", Animals);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
