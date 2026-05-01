using ShoppingApp.Model;
using System.ComponentModel;
using Wisej.Web;

namespace ShoppingApp.ViewModel
{
    public class ShoppingViewModel : INotifyPropertyChanged
    {
        private readonly IStoreRepository storeRepository;
        private readonly ICartRepository cartRepository;
        public event PropertyChangedEventHandler PropertyChanged;

        public BindingList<Product> Products { get; } = new();
        public BindingList<Product> Cart { get; } = new();

        public Command AddToCartCommand { get; }

        private Product _selectedProduct;
        public Product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
                AddToCartCommand.RaiseCanExecuteChanged();
            }
        }

        public void Load()
        {
            Products.Clear();

            foreach (var product in storeRepository.GetProducts())
                Products.Add(product);
            foreach (var product in cartRepository.GetProducts())
                Cart.Add(product);
        }

        public ShoppingViewModel(IStoreRepository storeRepository, ICartRepository cartRepository)
        {
            this.storeRepository = storeRepository;
            this.cartRepository = cartRepository;


        AddToCartCommand = new Command(
                execute: () => AddToCart(),
                canExecute: () => SelectedProduct != null
            );
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

            Products.Remove(productToMove);
            Cart.Add(productToMove);
        }

        private void OnPropertyChanged(string name)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
