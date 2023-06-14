namespace Shopping.Client.Models
{
    public class Product
    {
        public string Id { get; internal set; }
        public string Name { get; internal set; }
        public string Category { get; internal set; }
        public string Description { get; internal set; }
        public string ImageFile { get; internal set; }
        public decimal Price { get; internal set; }
    }
}
