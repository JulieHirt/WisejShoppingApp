using ShoppingApp.Model;
using System.ComponentModel;
using System.Drawing;
using Wisej.Web;

namespace ShoppingApp
{
    public partial class PageView : Page
    {
        BindingList<Product> storeStockList;
        public PageView()
        {
            InitializeComponent();

        }

        private void PageView_Load(object sender, System.EventArgs e)
        {
            storeStockList = new BindingList<Product>();
            Image apple = Image.FromFile(Application.MapPath("Images/apple.png"));
            storeStockList.Add(new Product(1, "apple", apple, 1.99m));
            
            Image banana = Image.FromFile(Application.MapPath("Images/banana.jpg"));
            storeStockList.Add(new Product(1, "banana", banana, .40m));
            
            Image orange = Image.FromFile(Application.MapPath("Images/orange.png"));
            storeStockList.Add(new Product(1, "orange", orange, 2.80m));


            dataRepeater1.DataSource = storeStockList;

            dataRepeater1.ItemTemplate.Controls["labelName"]
    .DataBindings.Add("Text", null, "Name");


        }
    }
}
