namespace SmartShop.Presentation
{
    partial class ProductForm
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
            Button btnDeleteProduct;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            txtPName = new TextBox();
            txtPDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPCategory = new Label();
            label5 = new Label();
            numPrice = new NumericUpDown();
            numPQuantity = new NumericUpDown();
            dataGridView1 = new DataGridView();
            btnshowprevious = new Button();
            comCategroy = new ComboBox();
            panel3 = new Panel();
            panel2 = new Panel();
            btnUpdateProduct = new Button();
            panel1 = new Panel();
            btnAddProduct = new Button();
            panel5 = new Panel();
            label4 = new Label();
            btnShowNext = new Button();
            panel4 = new Panel();
            btnDeleteProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.FromArgb(0, 0, 0, 255);
            btnDeleteProduct.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnDeleteProduct.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnDeleteProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteProduct.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDeleteProduct.ForeColor = Color.FromArgb(255, 64, 85);
            btnDeleteProduct.Image = (Image)resources.GetObject("btnDeleteProduct.Image");
            btnDeleteProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteProduct.Location = new Point(-13, -14);
            btnDeleteProduct.Margin = new Padding(0);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Padding = new Padding(30, 0, 0, 0);
            btnDeleteProduct.Size = new Size(272, 94);
            btnDeleteProduct.TabIndex = 1;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // txtPName
            // 
            txtPName.Location = new Point(259, 82);
            txtPName.MaximumSize = new Size(330, 50);
            txtPName.MinimumSize = new Size(200, 40);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(281, 40);
            txtPName.TabIndex = 3;
            // 
            // txtPDescription
            // 
            txtPDescription.Location = new Point(259, 190);
            txtPDescription.MaximumSize = new Size(330, 50);
            txtPDescription.MinimumSize = new Size(200, 40);
            txtPDescription.Name = "txtPDescription";
            txtPDescription.Size = new Size(281, 40);
            txtPDescription.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(85, 85, 84);
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(200, 38);
            label1.TabIndex = 8;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(85, 85, 84);
            label2.Location = new Point(12, 511);
            label2.Name = "label2";
            label2.Size = new Size(79, 38);
            label2.TabIndex = 9;
            label2.Text = "price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(85, 85, 84);
            label3.Location = new Point(12, 190);
            label3.Name = "label3";
            label3.Size = new Size(161, 38);
            label3.TabIndex = 10;
            label3.Text = "Description";
            // 
            // txtPCategory
            // 
            txtPCategory.AutoSize = true;
            txtPCategory.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtPCategory.ForeColor = Color.FromArgb(85, 85, 84);
            txtPCategory.Location = new Point(12, 314);
            txtPCategory.Name = "txtPCategory";
            txtPCategory.Size = new Size(217, 38);
            txtPCategory.TabIndex = 11;
            txtPCategory.Text = "Category Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(85, 85, 84);
            label5.Location = new Point(12, 416);
            label5.Name = "label5";
            label5.Size = new Size(233, 38);
            label5.TabIndex = 12;
            label5.Text = "Product Quantity";
            // 
            // numPrice
            // 
            numPrice.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numPrice.Location = new Point(259, 522);
            numPrice.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numPrice.MaximumSize = new Size(200, 0);
            numPrice.MinimumSize = new Size(200, 0);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(200, 27);
            numPrice.TabIndex = 13;
            numPrice.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // numPQuantity
            // 
            numPQuantity.Location = new Point(259, 427);
            numPQuantity.MaximumSize = new Size(200, 0);
            numPQuantity.MinimumSize = new Size(200, 0);
            numPQuantity.Name = "numPQuantity";
            numPQuantity.Size = new Size(200, 27);
            numPQuantity.TabIndex = 15;
            numPQuantity.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(599, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(562, 467);
            dataGridView1.TabIndex = 16;
            // 
            // btnshowprevious
            // 
            btnshowprevious.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnshowprevious.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnshowprevious.FlatStyle = FlatStyle.Flat;
            btnshowprevious.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnshowprevious.Image = (Image)resources.GetObject("btnshowprevious.Image");
            btnshowprevious.ImageAlign = ContentAlignment.MiddleLeft;
            btnshowprevious.Location = new Point(-9, -14);
            btnshowprevious.Name = "btnshowprevious";
            btnshowprevious.Padding = new Padding(30, 0, 0, 0);
            btnshowprevious.Size = new Size(130, 92);
            btnshowprevious.TabIndex = 18;
            btnshowprevious.UseVisualStyleBackColor = true;
            btnshowprevious.Click += btnshowprevious_Click;
            // 
            // comCategroy
            // 
            comCategroy.FormattingEnabled = true;
            comCategroy.ItemHeight = 20;
            comCategroy.Location = new Point(259, 314);
            comCategroy.MaximumSize = new Size(200, 0);
            comCategroy.MaxLength = 100;
            comCategroy.MinimumSize = new Size(200, 0);
            comCategroy.Name = "comCategroy";
            comCategroy.Size = new Size(200, 28);
            comCategroy.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDeleteProduct);
            panel3.Location = new Point(668, 664);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 71);
            panel3.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnUpdateProduct);
            panel2.Location = new Point(388, 656);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 69);
            panel2.TabIndex = 21;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = Color.FromArgb(0, 0, 0, 255);
            btnUpdateProduct.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnUpdateProduct.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnUpdateProduct.FlatStyle = FlatStyle.Flat;
            btnUpdateProduct.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnUpdateProduct.ForeColor = Color.FromArgb(139, 183, 240);
            btnUpdateProduct.Image = (Image)resources.GetObject("btnUpdateProduct.Image");
            btnUpdateProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateProduct.Location = new Point(-15, -2);
            btnUpdateProduct.Margin = new Padding(4);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Padding = new Padding(30, 0, 0, 0);
            btnUpdateProduct.Size = new Size(288, 82);
            btnUpdateProduct.TabIndex = 1;
            btnUpdateProduct.Text = "Update ";
            btnUpdateProduct.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddProduct);
            panel1.Location = new Point(88, 658);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 77);
            panel1.TabIndex = 20;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(0, 0, 0, 255);
            btnAddProduct.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnAddProduct.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddProduct.ForeColor = Color.FromArgb(148, 216, 45);
            btnAddProduct.Image = (Image)resources.GetObject("btnAddProduct.Image");
            btnAddProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddProduct.Location = new Point(-6, -2);
            btnAddProduct.Margin = new Padding(4);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Padding = new Padding(30, 0, 0, 0);
            btnAddProduct.Size = new Size(290, 84);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Add ";
            btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnshowprevious);
            panel5.Location = new Point(732, 555);
            panel5.Name = "panel5";
            panel5.Size = new Size(107, 62);
            panel5.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(85, 85, 84);
            label4.Location = new Point(795, 24);
            label4.Name = "label4";
            label4.Size = new Size(159, 46);
            label4.TabIndex = 25;
            label4.Text = "Products";
            // 
            // btnShowNext
            // 
            btnShowNext.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnShowNext.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnShowNext.FlatStyle = FlatStyle.Flat;
            btnShowNext.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnShowNext.Image = (Image)resources.GetObject("btnShowNext.Image");
            btnShowNext.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowNext.Location = new Point(-14, -21);
            btnShowNext.Name = "btnShowNext";
            btnShowNext.Padding = new Padding(30, 0, 0, 0);
            btnShowNext.Size = new Size(132, 97);
            btnShowNext.TabIndex = 17;
            btnShowNext.UseVisualStyleBackColor = true;
            btnShowNext.Click += btnShowNext_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnShowNext);
            panel4.Location = new Point(903, 560);
            panel4.Name = "panel4";
            panel4.Size = new Size(105, 57);
            panel4.TabIndex = 23;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 239, 239);
            ClientSize = new Size(1197, 776);
            Controls.Add(label4);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(comCategroy);
            Controls.Add(dataGridView1);
            Controls.Add(numPQuantity);
            Controls.Add(numPrice);
            Controls.Add(label5);
            Controls.Add(txtPCategory);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPDescription);
            Controls.Add(txtPName);
            MaximizeBox = false;
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPName;
        private TextBox txtPDescription;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label txtPCategory;
        private Label label5;
        private NumericUpDown numPrice;
        private NumericUpDown numPQuantity;
        private DataGridView dataGridView1;
        private Button btnshowprevious;
        private ComboBox comCategroy;
        private Panel panel3;
        private Panel panel2;
        private Button btnUpdateProduct;
        private Panel panel1;
        private Button btnAddProduct;
        private Panel panel5;
        private Label label4;
        private Button btnShowNext;
        private Panel panel4;
    }
}