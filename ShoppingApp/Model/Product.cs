using System.Drawing;

namespace ShoppingApp.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Image Image { get; set; }
        public decimal Price { get; set; }


        public Product(int id, string name, Image image, decimal price)
        {
            Id = id;
            Name = name;
            Image = image;
            Price = price;
        }
    }
}
