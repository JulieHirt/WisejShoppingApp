using ShoppingApp.Model;
using System.ComponentModel;
using System.Drawing;
using Wisej.Web;

namespace ShoppingApp
{
    public partial class PageView : Page
    {
        BindingList<Product> storeStockList;
        BindingList<Product> cartList;
        Command AddToCartCommand;
        public PageView()
        {
            InitializeComponent();
            AddToCartCommand = new Command(() => { AlertBox.Show("Added To Cart"); }, () => { return true; });
        }

        private void PageView_Load(object sender, System.EventArgs e)
        {
            

            dataRepeater1.DataSource = storeStockList;

            labelName.DataBindings.Add("Text", dataRepeater1.DataSource, "Name");
            labelPrice.DataBindings.Add("Text", dataRepeater1.DataSource, "Price");
            pictureBox1.DataBindings.Add("Image", dataRepeater1.DataSource, "Image");
            buttonAddToCart.Command = AddToCartCommand;


            cartList = new BindingList<Product>();
            Image apple1 = Image.FromFile(Application.MapPath("Images/apple.png"));
            cartList.Add(new Product(1, "apple", apple1, 1.99m));

            dataGridView1.DataSource = cartList;

        }

        

    }
}
