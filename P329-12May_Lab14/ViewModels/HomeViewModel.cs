using P329_12May_Lab14.Models;

namespace P329_12May_Lab14.ViewModels
{
    public class HomeViewModel
    {
        public List<Coffee> Coffees { get; set; } = new();
        public List<Customer> Customers { get; set; } = new();
        public List<Blog> Blogs { get; set; } = new();
    }
}
