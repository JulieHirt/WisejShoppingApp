using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Wisej.Web;

namespace ShoppingApp.Model
{

    public interface IStoreRepository
    {
        IList<Product> GetProducts();
        void AddProduct(Product product);
        void RemoveProduct(int productId);
    }
    public class StoreRepository : IStoreRepository
    {
        private readonly List<Product> storeStockList;
        public StoreRepository()
        {
            Image apple = Image.FromFile(Application.MapPath("Images/apple.png"));
            Image banana = Image.FromFile(Application.MapPath("Images/banana.jpg"));
            Image orange = Image.FromFile(Application.MapPath("Images/orange.png"));
            storeStockList = new List<Product>()
            {
                new Product(1, "apple", apple, 1.99m),
                new Product(2, "banana", banana, .40m),
                new Product(3, "orange", orange, 2.80m)
            };
        }

        public IList<Product> GetProducts()
        {
            return storeStockList;
        }

        public void AddProduct(Product product)
        {
            storeStockList.Add(product);
        }

        public void RemoveProduct(int productId)
        {
            var product = storeStockList.FirstOrDefault(p => p.Id == productId);

            if (product != null)
                storeStockList.Remove(product);
        }

    }
}
