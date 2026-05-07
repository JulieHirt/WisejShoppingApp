using ShoppingApp.Model;
using ShoppingApp.ViewModel;
using System.ComponentModel;
using System.Drawing;
using Wisej.Web;

namespace ShoppingApp
{
    public partial class PageView : Page
    {
        private readonly ShoppingViewModel viewModel;
        public PageView()
        {
            InitializeComponent();
            viewModel = new ShoppingViewModel(new StoreRepository(), new CartRepository());

            dataRepeater1.DataSource = viewModel.Products;
            dataGridView1.DataSource = viewModel.Cart;
            viewModel.Load();
        }

        private void PageView_Load(object sender, System.EventArgs e)
        {
            


            labelName.DataBindings.Add("Text", dataRepeater1.DataSource, "Name");
            labelPrice.DataBindings.Add("Text", dataRepeater1.DataSource, "Price");
            pictureBox1.DataBindings.Add("Image", dataRepeater1.DataSource, "Image");
            buttonAddToCart.Command = viewModel.AddToCartCommand;
            buttonCheckout.Command = viewModel.CheckoutCommand;

        }

        private void dataRepeater1_CurrentItemIndexChanged(object sender, System.EventArgs e)
        {
            int index = dataRepeater1.CurrentItemIndex;
            if (index >= 0 && index < viewModel.Products.Count)
            {
                viewModel.SelectedProduct = viewModel.Products[index];
            }
        }


        //fired when a new item is created in a datarepeater
        private void dataRepeater1_ItemCloned(object sender, DataRepeaterItemEventArgs e)
        {
            //check that buttonAddToCart is a button
            if (e.DataRepeaterItem.Controls["buttonAddToCart"] is Button button)
            {
                //make sure that UpdateSelectedProduct is only attached once
                button.Click -= UpdateSelectedProduct;
                button.Click += UpdateSelectedProduct;
            }
        }

        private void UpdateSelectedProduct(object sender, System.EventArgs e)
        {
            //check that the sender (the one who called this method) is a Wisej Control with a DataRepeater parent
            if (sender is not Control control || control.Parent is not DataRepeaterItem item)
            {
                return;
            }


            //updated SelectedProduct in the viewModel based on the selected item index in the datarepeater
            int index = item.ItemIndex;
            if (index >= 0 && index < viewModel.Products.Count)
            {
                viewModel.SelectedProduct = viewModel.Products[index];
            }
            else
            {
                viewModel.SelectedProduct = null;
            }
        }
    }
}
