using Microsoft.AspNetCore.Mvc;
using P329_12May_Lab14.Models;
using P329_12May_Lab14.ViewModels;

namespace P329_12May_Lab14.Controllers
{
    public class CoffeesController : Controller
    {
        private readonly List<Coffee> _coffees = new()
            {
                new Coffee
                {
                    Id = 1,
                    ImageName="img-1.png",
                    Name="Coffee 1",
                    Overview="this is coffee 1"
                },
                new Coffee
                {
                    Id = 2,
                    ImageName="img-2.png",
                    Name="Coffee 2",
                    Overview="this is coffee 2"
                },
                new Coffee
                {
                    Id = 3,
                    ImageName="img-3.png",
                    Name="Coffee 3",
                    Overview="this is coffee 3"
                },
                new Coffee
                {
                    Id = 4,
                    ImageName="img-4.png",
                    Name="Coffee 4",
                    Overview="this is coffee 4"
                },
                new Coffee
                {
                    Id = 5,
                    ImageName="img-2.png",
                    Name="Coffee 5",
                    Overview="this is coffee 5"
                },
                new Coffee
                {
                    Id = 6,
                    ImageName="img-3.png",
                    Name="Coffee 6",
                    Overview="this is coffee 6"
                },
                new Coffee
                {
                    Id = 7,
                    ImageName="img-4.png",
                    Name="Coffee 7",
                    Overview="this is coffee 7"
                },
            };
        public IActionResult Index()
        {
            CoffeesViewModel model = new()
            {
                Coffees = _coffees
            };

            return View(model);
        }

        public IActionResult Details(int? id)
        {
            if (id is null) return NotFound();

            var data = _coffees.FirstOrDefault(coffee => coffee.Id == id);

            if (data is null) return BadRequest();

            return View(data);
        }
    }
}
