namespace SmartShop.Presentation
{
    partial class DisplayProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayProduct));
            btnDeleteFromCard = new Button();
            btnAddToCard = new Button();
            btnSearch = new Button();
            btnBuy = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            txtPrice = new RichTextBox();
            txtSearch = new TextBox();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            btnPrevious = new Button();
            panel4 = new Panel();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeleteFromCard
            // 
            btnDeleteFromCard.BackColor = Color.FromArgb(0, 0, 0, 255);
            btnDeleteFromCard.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnDeleteFromCard.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnDeleteFromCard.FlatStyle = FlatStyle.Flat;
            btnDeleteFromCard.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDeleteFromCard.ForeColor = Color.FromArgb(255, 64, 85);
            btnDeleteFromCard.Image = (Image)resources.GetObject("btnDeleteFromCard.Image");
            btnDeleteFromCard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteFromCard.Location = new Point(-13, -14);
            btnDeleteFromCard.Margin = new Padding(0);
            btnDeleteFromCard.Name = "btnDeleteFromCard";
            btnDeleteFromCard.Padding = new Padding(30, 0, 0, 0);
            btnDeleteFromCard.Size = new Size(262, 94);
            btnDeleteFromCard.TabIndex = 1;
            btnDeleteFromCard.Text = "Delete";
            btnDeleteFromCard.UseVisualStyleBackColor = false;
            btnDeleteFromCard.Click += btnDeleteFromCard_Click;
            // 
            // btnAddToCard
            // 
            btnAddToCard.BackColor = Color.FromArgb(0, 0, 0, 255);
            btnAddToCard.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnAddToCard.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnAddToCard.FlatStyle = FlatStyle.Flat;
            btnAddToCard.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddToCard.ForeColor = Color.FromArgb(152, 201, 0);
            btnAddToCard.Image = (Image)resources.GetObject("btnAddToCard.Image");
            btnAddToCard.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddToCard.Location = new Point(-9, -14);
            btnAddToCard.Margin = new Padding(0);
            btnAddToCard.Name = "btnAddToCard";
            btnAddToCard.Padding = new Padding(30, 0, 0, 0);
            btnAddToCard.Size = new Size(240, 94);
            btnAddToCard.TabIndex = 1;
            btnAddToCard.Text = "Add";
            btnAddToCard.UseVisualStyleBackColor = true;
            btnAddToCard.Click += btnAddToCard_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 0, 0, 255);
            btnSearch.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.FromArgb(255, 64, 85);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(-13, -3);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(30, 0, 0, 0);
            btnSearch.Size = new Size(220, 83);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "  ";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.FromArgb(0, 0, 0, 255);
            btnBuy.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnBuy.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBuy.ForeColor = Color.FromArgb(152, 201, 0);
            btnBuy.Image = (Image)resources.GetObject("btnBuy.Image");
            btnBuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuy.Location = new Point(-9, -14);
            btnBuy.Margin = new Padding(0);
            btnBuy.Name = "btnBuy";
            btnBuy.Padding = new Padding(30, 0, 0, 0);
            btnBuy.Size = new Size(247, 94);
            btnBuy.TabIndex = 1;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(778, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(560, 449);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(85, 85, 84);
            label1.Location = new Point(195, 26);
            label1.Name = "label1";
            label1.Size = new Size(98, 46);
            label1.TabIndex = 2;
            label1.Text = " Cart";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(18, 86);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(520, 449);
            dataGridView2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(85, 85, 84);
            label2.Location = new Point(26, 569);
            label2.Name = "label2";
            label2.Size = new Size(147, 38);
            label2.TabIndex = 6;
            label2.Text = "Total Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(186, 559);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 60);
            txtPrice.TabIndex = 7;
            txtPrice.Text = "";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1016, 32);
            txtSearch.MaximumSize = new Size(320, 45);
            txtSearch.MinimumSize = new Size(300, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(320, 40);
            txtSearch.TabIndex = 9;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDeleteFromCard);
            panel3.Location = new Point(544, 319);
            panel3.Name = "panel3";
            panel3.Size = new Size(191, 71);
            panel3.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddToCard);
            panel1.Location = new Point(544, 184);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 71);
            panel1.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSearch);
            panel2.Location = new Point(930, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(84, 71);
            panel2.TabIndex = 29;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnBuy);
            panel6.Location = new Point(348, 559);
            panel6.Name = "panel6";
            panel6.Size = new Size(190, 71);
            panel6.TabIndex = 30;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnPrevious);
            panel5.Location = new Point(943, 559);
            panel5.Name = "panel5";
            panel5.Size = new Size(107, 62);
            panel5.TabIndex = 32;
            // 
            // btnPrevious
            // 
            btnPrevious.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnPrevious.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrevious.Location = new Point(-9, -14);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Padding = new Padding(30, 0, 0, 0);
            btnPrevious.Size = new Size(130, 92);
            btnPrevious.TabIndex = 18;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnNext);
            panel4.Location = new Point(1114, 564);
            panel4.Name = "panel4";
            panel4.Size = new Size(105, 57);
            panel4.TabIndex = 31;
            // 
            // btnNext
            // 
            btnNext.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnNext.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.ImageAlign = ContentAlignment.MiddleLeft;
            btnNext.Location = new Point(-14, -21);
            btnNext.Name = "btnNext";
            btnNext.Padding = new Padding(30, 0, 0, 0);
            btnNext.Size = new Size(132, 97);
            btnNext.TabIndex = 17;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // DisplayProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 650);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(txtSearch);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "DisplayProduct";
            Text = "DisplayProduct";
            Load += DisplayProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private DataGridView dataGridView2;
        private Label label2;
        private RichTextBox txtPrice;
        private TextBox txtSearch;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private Button btnDeleteFromCard;
        private Button btnAddToCard;
        private Button btnSearch;
        private Button btnBuy;
        private Panel panel5;
        private Button btnPrevious;
        private Panel panel4;
        private Button btnNext;
    }
}