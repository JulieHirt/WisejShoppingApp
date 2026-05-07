using ShoppingApp.Model;
using System.ComponentModel;
using System.Linq;
using Wisej.Web;

namespace ShoppingApp.ViewModel
{
    public class ShoppingViewModel
    {
        private readonly IStoreRepository storeRepository;
        private readonly ICartRepository cartRepository;

        public BindingList<Product> Products { get; } = new();
        public BindingList<Product> Cart { get; } = new();

        public Command AddToCartCommand { get; }
        public Command CheckoutCommand { get; }

        private Product _selectedProduct;
        public Product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                AddToCartCommand.RaiseCanExecuteChanged();
            }
        }

        public ShoppingViewModel(IStoreRepository storeRepository, ICartRepository cartRepository)
        {
            this.storeRepository = storeRepository;
            this.cartRepository = cartRepository;


        AddToCartCommand = new Command(
                execute: () => AddToCart(),
                canExecute: () => SelectedProduct != null
            );

        CheckoutCommand = new Command(
                 execute: () => Checkout(),
                 canExecute: () => cartRepository.GetProducts().Count > 0

             );
        }

        public void Load()
        {
            Products.Clear();
            Cart.Clear();

            foreach (var product in storeRepository.GetProducts())
                Products.Add(product);
            foreach (var product in cartRepository.GetProducts())
                Cart.Add(product);
            CheckoutCommand.RaiseCanExecuteChanged();
        }

        private void Checkout()
        {
           decimal total = Cart.Sum(p => p.Price);
           MessageBox.Show("Your total is: " + total);

            //Empty cart
            Cart.Clear(); //UI
            cartRepository.ClearProducts(); //database
            CheckoutCommand.RaiseCanExecuteChanged();
        }
        private void AddToCart()
        {
            AlertBox.Show("Added To Cart");
            if (SelectedProduct == null)
            {
                return;
            }

            var productToMove = SelectedProduct;

            storeRepository.RemoveProduct(productToMove.Id);
            cartRepository.AddProduct(productToMove);
            CheckoutCommand.RaiseCanExecuteChanged();

            Products.Remove(productToMove);
            Cart.Add(productToMove);
        }

    }
}
