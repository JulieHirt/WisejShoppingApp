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
        }

        private void PageView_Load(object sender, System.EventArgs e)
        {
            


            labelName.DataBindings.Add("Text", dataRepeater1.DataSource, "Name");
            labelPrice.DataBindings.Add("Text", dataRepeater1.DataSource, "Price");
            pictureBox1.DataBindings.Add("Image", dataRepeater1.DataSource, "Image");
            buttonAddToCart.Command = viewModel.AddToCartCommand;

        }

        

    }
}
