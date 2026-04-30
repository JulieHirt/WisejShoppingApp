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
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.buttonCheckout = new Wisej.Web.Button();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.textBox1 = new Wisej.Web.TextBox();
            this.button1 = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).BeginInit();
            this.dataRepeater1.ItemTemplate.SuspendLayout();
            this.dataRepeater1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.ItemSize = new System.Drawing.Size(200, 100);
            // 
            // dataRepeater1.ItemTemplate
            // 
            this.dataRepeater1.ItemTemplate.Controls.Add(this.button1);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.textBox1);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.pictureBox1);
            this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(393, 100);
            this.dataRepeater1.Location = new System.Drawing.Point(24, 32);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Size = new System.Drawing.Size(397, 311);
            this.dataRepeater1.TabIndex = 0;
            this.dataRepeater1.Text = "dataRepeater1";
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(136, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 75);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add to Cart";
            // 
            // Page1
            // 
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataRepeater1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1284, 388);
            this.dataRepeater1.ItemTemplate.ResumeLayout(false);
            this.dataRepeater1.ItemTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).EndInit();
            this.dataRepeater1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.DataRepeater dataRepeater1;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.Button buttonCheckout;
        private Wisej.Web.TextBox textBox1;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.Button button1;
    }
}
