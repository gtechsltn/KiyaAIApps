namespace Blzor_Appq    .Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class Categories : List<Category>
    {
        public Categories()
        {
            Add(new Category() { CategoryId = 1, CategoryName = "C1" });
            Add(new Category() { CategoryId = 2, CategoryName = "C2" });
        }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
    }

    public class Products : List<Product>
    {
        public Products()
        {
            Add(new Product() { ProductId = 11, ProductName = "P1", CategoryId = 1 });
            Add(new Product() { ProductId = 12, ProductName = "P2", CategoryId = 2 });
            Add(new Product() { ProductId = 13, ProductName = "P3", CategoryId = 1 });
            Add(new Product() { ProductId = 14, ProductName = "P4", CategoryId = 2 });
        }
    }
}
