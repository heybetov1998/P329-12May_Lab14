using Microsoft.AspNetCore.Mvc;
using P329_12May_Lab14.Models;
using P329_12May_Lab14.ViewModels;
using System.Collections.Generic;

namespace P329_12May_Lab14.Controllers
{
    public class BlogController : Controller
    {
        private readonly List<Blog> _blogs = new()
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
        public IActionResult Index()
        {
            BlogViewModel model = new()
            {
                Blogs = _blogs
            };

            return View(model);
        }

        public IActionResult Details(int? id)
        {
            if (id is null) return NotFound();

            var data = _blogs.FirstOrDefault(coffee => coffee.Id == id);

            if (data is null) return BadRequest();

            return View(data);
        }
    }
}
