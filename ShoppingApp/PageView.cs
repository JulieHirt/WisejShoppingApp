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
            //if (e.DataRepeaterItem.Controls["buttonAddToCart"] is Button button)
            //{
            //    button.Click -= buttonAddToCart_Click;
            //    button.Click += buttonAddToCart_Click;
            //}
        }

        private void buttonAddToCart_Click(object sender, System.EventArgs e)
        {
            if (sender is not Control control || control.Parent is not DataRepeaterItem item)
            {
                return;
            }

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
