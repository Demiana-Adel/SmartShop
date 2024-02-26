namespace Markt.Presentation
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            btnDeleteOrder = new Button();
            dataGridView1 = new DataGridView();
            comState = new ComboBox();
            label1 = new Label();
            panel5 = new Panel();
            btnPrevious = new Button();
            panel4 = new Panel();
            btnNext = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            btnUpdateOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.BackColor = Color.FromArgb(0, 0, 0, 255);
            btnDeleteOrder.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnDeleteOrder.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnDeleteOrder.FlatStyle = FlatStyle.Flat;
            btnDeleteOrder.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDeleteOrder.ForeColor = Color.FromArgb(255, 64, 85);
            btnDeleteOrder.Image = (Image)resources.GetObject("btnDeleteOrder.Image");
            btnDeleteOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteOrder.Location = new Point(-13, -14);
            btnDeleteOrder.Margin = new Padding(0);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Padding = new Padding(30, 0, 0, 0);
            btnDeleteOrder.Size = new Size(272, 94);
            btnDeleteOrder.TabIndex = 1;
            btnDeleteOrder.Text = "Delete";
            btnDeleteOrder.UseVisualStyleBackColor = false;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(593, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(633, 375);
            dataGridView1.TabIndex = 0;
            // 
            // comState
            // 
            comState.FormattingEnabled = true;
            comState.Location = new Point(226, 94);
            comState.MinimumSize = new Size(300, 0);
            comState.Name = "comState";
            comState.Size = new Size(300, 28);
            comState.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(85, 85, 84);
            label1.Location = new Point(43, 84);
            label1.Name = "label1";
            label1.Size = new Size(162, 38);
            label1.TabIndex = 6;
            label1.Text = "Order State";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnPrevious);
            panel5.Location = new Point(792, 441);
            panel5.Name = "panel5";
            panel5.Size = new Size(107, 62);
            panel5.TabIndex = 34;
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
            panel4.Location = new Point(963, 446);
            panel4.Name = "panel4";
            panel4.Size = new Size(105, 57);
            panel4.TabIndex = 33;
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
            // panel3
            // 
            panel3.Controls.Add(btnDeleteOrder);
            panel3.Location = new Point(304, 342);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 71);
            panel3.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnUpdateOrder);
            panel2.Location = new Point(43, 333);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 69);
            panel2.TabIndex = 35;
            // 
            // btnUpdateOrder
            // 
            btnUpdateOrder.BackColor = Color.FromArgb(0, 0, 0, 255);
            btnUpdateOrder.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnUpdateOrder.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnUpdateOrder.FlatStyle = FlatStyle.Flat;
            btnUpdateOrder.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnUpdateOrder.ForeColor = Color.FromArgb(139, 183, 240);
            btnUpdateOrder.Image = (Image)resources.GetObject("btnUpdateOrder.Image");
            btnUpdateOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateOrder.Location = new Point(-15, -2);
            btnUpdateOrder.Margin = new Padding(4);
            btnUpdateOrder.Name = "btnUpdateOrder";
            btnUpdateOrder.Padding = new Padding(30, 0, 0, 0);
            btnUpdateOrder.Size = new Size(288, 82);
            btnUpdateOrder.TabIndex = 1;
            btnUpdateOrder.Text = "Update ";
            btnUpdateOrder.UseVisualStyleBackColor = false;
            btnUpdateOrder.Click += btnUpdateOrder_Click;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 239, 239);
            ClientSize = new Size(1276, 530);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(label1);
            Controls.Add(comState);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "OrdersForm";
            Text = "OrdersForm";
            Load += OrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnUpdateOrder;
        private Button btnDeleteOrder;
        private ComboBox comState;
        private Label label1;
        private Panel panel5;
        private Button btnPrevious;
        private Panel panel4;
        private Button btnNext;
        private Panel panel3;
        private Panel panel2;
        private Button btnUpdateProduct;
    }
}