namespace ktraltweb.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime PublishedDate { get; set; }

        // Thêm các thuộc tính thiếu
        public string Description { get; set; } = string.Empty;  // Thuộc tính Description
        public string Image { get; set; } = string.Empty;        // Thuộc tính Image
    }
}
