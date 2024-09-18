namespace Api.Model
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Desc { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }
        public string? Img { get; set; }
    }
}