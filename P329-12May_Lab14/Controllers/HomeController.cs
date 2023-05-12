using Microsoft.AspNetCore.Mvc;
using P329_12May_Lab14.Models;
using P329_12May_Lab14.ViewModels;

namespace P329_12May_Lab14.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Coffee> coffees = new()
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
            List<Blog> blogs = new()
            {
                new Blog
                {
                    Id=1,
                    Title="Blog 1",
                    Content="Content of blog 1",
                    ImageName="blog-img1.png",
                    CreatedDate=DateTime.UtcNow,
                },
                new Blog
                {
                    Id=2,
                    Title="Blog 2",
                    Content="Content of blog 2",
                    ImageName="blog-img2.png",
                    CreatedDate=DateTime.UtcNow
                },
                new Blog
                {
                    Id=3,
                    Title="Blog 3",
                    Content="Content of blog 3",
                    ImageName="blog-img1.png",
                    CreatedDate=DateTime.UtcNow
                },
                new Blog
                {
                    Id=4,
                    Title="Blog 4",
                    Content="Content of blog 4",
                    ImageName="blog-img2.png",
                    CreatedDate=DateTime.UtcNow
                },
            };
            List<Customer> customers = new()
            {
                new Customer
                {
                    Id=1,
                    FullName="First Customer",
                    ImageName="client-img1.png",
                    Review="Review of customer 1"
                },
                new Customer
                {
                    Id=2,
                    FullName="Second Customer",
                    ImageName="client-img2.png",
                    Review="Review of customer 2"
                },
                new Customer
                {
                    Id=3,
                    FullName="Third Customer",
                    ImageName="client-img3.png",
                    Review="Review of customer 3"
                },
                new Customer
                {
                    Id=4,
                    FullName="Fourth Customer",
                    ImageName="client-img2.png",
                    Review="Review of customer 4"
                },
            };

            HomeViewModel model = new()
            {
                Coffees = coffees.Take(4).ToList(),
                Blogs = blogs.Take(2).ToList(),
                Customers = customers
            };

            ViewData["isHomepage"] = true;
            return View(model);
        }
    }
}
