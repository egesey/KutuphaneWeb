namespace KutuphaneWeb.Models
{
    public class Book
    {
        public int BId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int Year { get; set; } = 0;
        public decimal Price { get; set; } = 0.0m;
    }
}