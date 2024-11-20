namespace Teszt_LA01.Models
{
    public class Category
    {
        public int CategoryId { get; set; } // Primary Key
        public string Name { get; set; }    // Name of the category
        public string Description { get; set; } // Description of the category

        // Navigation property for related Products
        public ICollection<Product>? Products { get; set; }
    }
}
