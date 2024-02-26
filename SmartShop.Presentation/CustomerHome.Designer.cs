namespace SmartShop.Presentation
{
    partial class CustomerHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHome));
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2 = new Panel();
            home = new Button();
            panel4 = new Panel();
            Product = new Button();
            flowLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel2.BackgroundImage");
            flowLayoutPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1149, 549);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoScrollMargin = new Size(10, 10);
            panel2.BackColor = Color.FromArgb(0, 0, 0, 255);
            panel2.Controls.Add(home);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 51);
            panel2.TabIndex = 5;
            // 
            // home
            // 
            home.BackColor = Color.FromArgb(0, 0, 0, 255);
            home.DialogResult = DialogResult.Continue;
            home.FlatAppearance.MouseDownBackColor = Color.DimGray;
            home.FlatAppearance.MouseOverBackColor = Color.DimGray;
            home.FlatStyle = FlatStyle.Flat;
            home.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            home.ForeColor = Color.FromArgb(228, 235, 240);
            home.Image = (Image)resources.GetObject("home.Image");
            home.ImageAlign = ContentAlignment.MiddleLeft;
            home.Location = new Point(-3, -5);
            home.Name = "home";
            home.Padding = new Padding(30, 0, 0, 0);
            home.Size = new Size(306, 68);
            home.TabIndex = 0;
            home.Text = "         Home";
            home.TextAlign = ContentAlignment.MiddleLeft;
            home.UseVisualStyleBackColor = false;
            home.Click += home_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoScrollMargin = new Size(10, 10);
            panel4.BackColor = Color.FromArgb(0, 0, 0, 255);
            panel4.Controls.Add(Product);
            panel4.Location = new Point(285, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(276, 53);
            panel4.TabIndex = 7;
            // 
            // Product
            // 
            Product.FlatAppearance.MouseDownBackColor = Color.DimGray;
            Product.FlatAppearance.MouseOverBackColor = Color.DimGray;
            Product.FlatStyle = FlatStyle.Flat;
            Product.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Product.ForeColor = Color.FromArgb(228, 235, 240);
            Product.Image = (Image)resources.GetObject("Product.Image");
            Product.ImageAlign = ContentAlignment.MiddleLeft;
            Product.Location = new Point(-21, -12);
            Product.Name = "Product";
            Product.Padding = new Padding(30, 0, 0, 0);
            Product.Size = new Size(311, 81);
            Product.TabIndex = 0;
            Product.Text = "          Products";
            Product.TextAlign = ContentAlignment.MiddleLeft;
            Product.UseVisualStyleBackColor = true;
            Product.Click += Product_Click;
            // 
            // CustomerHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 549);
            Controls.Add(flowLayoutPanel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerHome";
            ShowInTaskbar = false;
            Text = "CustomerHome";
            flowLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button login;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private Button home;
        private Panel panel4;
        private Button Product;
    }
}