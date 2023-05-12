namespace P329_12May_Lab14.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? ImageName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
