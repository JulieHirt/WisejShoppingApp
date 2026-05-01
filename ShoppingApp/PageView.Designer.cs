namespace ShoppingApp
{
    partial class PageView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataRepeater1 = new Wisej.Web.DataRepeater();
            this.labelPrice = new Wisej.Web.Label();
            this.labelName = new Wisej.Web.Label();
            this.buttonAddToCart = new Wisej.Web.Button();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.buttonCheckout = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).BeginInit();
            this.dataRepeater1.ItemTemplate.SuspendLayout();
            this.dataRepeater1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.ItemSize = new System.Drawing.Size(200, 100);
            // 
            // dataRepeater1.ItemTemplate
            // 
            this.dataRepeater1.ItemTemplate.Controls.Add(this.labelPrice);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.labelName);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.buttonAddToCart);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.pictureBox1);
            this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(393, 100);
            this.dataRepeater1.Location = new System.Drawing.Point(24, 32);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Size = new System.Drawing.Size(397, 311);
            this.dataRepeater1.TabIndex = 0;
            this.dataRepeater1.Text = "dataRepeater1";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(3, 56);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(60, 18);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "labelPrice";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(66, 18);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "labelName";
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Location = new System.Drawing.Point(257, 34);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(97, 30);
            this.buttonAddToCart.TabIndex = 2;
            this.buttonAddToCart.Text = "Add to Cart";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(136, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 75);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(511, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 164);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Location = new System.Drawing.Point(607, 259);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(222, 83);
            this.buttonCheckout.TabIndex = 2;
            this.buttonCheckout.Text = "Checkout";
            // 
            // PageView
            // 
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataRepeater1);
            this.Name = "PageView";
            this.Size = new System.Drawing.Size(1284, 388);
            this.Load += new System.EventHandler(this.PageView_Load);
            this.dataRepeater1.ItemTemplate.ResumeLayout(false);
            this.dataRepeater1.ItemTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).EndInit();
            this.dataRepeater1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.DataRepeater dataRepeater1;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.Button buttonCheckout;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.Button buttonAddToCart;
        private Wisej.Web.Label labelPrice;
        private Wisej.Web.Label labelName;
    }
}
