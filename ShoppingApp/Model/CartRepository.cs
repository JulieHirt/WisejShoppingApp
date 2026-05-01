using System.Collections.Generic;
using System.Linq;

namespace ShoppingApp.Model
{
    //very similar to Store Repository. In a more complex app these would be more different
    public interface ICartRepository
    {
        IList<Product> GetProducts();
        void AddProduct(Product product);
        void RemoveProduct(int productId);
    }
    public class CartRepository: ICartRepository
    {
         private readonly List<Product> cartList;
        public CartRepository()
        {
            cartList = new List<Product>();
        }

        public IList<Product> GetProducts()
        {
            return cartList;
        }

        public void AddProduct(Product product)
        {
            cartList.Add(product);
        }

        public void RemoveProduct(int productId)
        {
            var product = cartList.FirstOrDefault(p => p.Id == productId);

            if (product != null)
                cartList.Remove(product);
        }
    
    }
}
