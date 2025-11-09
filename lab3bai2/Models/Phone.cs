namespace lab3bai2.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;    // ví dụ: "iPhone 14"
        public string Brand { get; set; } = string.Empty;   // ví dụ: "Apple"
        public decimal Price { get; set; }                  // ví dụ: 19990000
        public string Image { get; set; } = string.Empty;   // đường dẫn trong wwwroot/images/
        public string Description { get; set; } = string.Empty;
    }
}
