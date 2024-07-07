namespace FirstApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
        public Int64 Stock { get; set; }

    }
}
