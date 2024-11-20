namespace Teszt_LA01.Models
{
    public class Product
    {
        public int ProductId { get; set; } // Primary Key
        public string Name { get; set; }   // Name of the product
        public string Description { get; set; } // Description of the product
        public int Price { get; set; }     // Price of the product (integer)
        public bool IsActive { get; set; } // Active status of the product

        // Foreign Key for Category
        public int CategoryId { get; set; }

        // Navigation property for related Category
        public Category Category { get; set; }
    }
}
