namespace practical12.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Foreign Key
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
