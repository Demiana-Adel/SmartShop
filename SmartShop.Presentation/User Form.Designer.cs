namespace SmartShop.Presentation
{
    partial class User_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Form));
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            btnPrevious = new Button();
            panel4 = new Panel();
            BtnNext = new Button();
            panel3 = new Panel();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(906, 328);
            dataGridView1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnPrevious);
            panel5.Location = new Point(549, 386);
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
            panel4.Controls.Add(BtnNext);
            panel4.Location = new Point(720, 391);
            panel4.Name = "panel4";
            panel4.Size = new Size(105, 57);
            panel4.TabIndex = 33;
            // 
            // BtnNext
            // 
            BtnNext.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            BtnNext.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            BtnNext.FlatStyle = FlatStyle.Flat;
            BtnNext.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BtnNext.Image = (Image)resources.GetObject("BtnNext.Image");
            BtnNext.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNext.Location = new Point(-14, -21);
            BtnNext.Name = "BtnNext";
            BtnNext.Padding = new Padding(30, 0, 0, 0);
            BtnNext.Size = new Size(132, 97);
            BtnNext.TabIndex = 17;
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDelete);
            panel3.Location = new Point(142, 386);
            panel3.Name = "panel3";
            panel3.Size = new Size(191, 71);
            panel3.TabIndex = 35;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(0, 0, 0, 255);
            btnDelete.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(255, 64, 85);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(-13, -14);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(30, 0, 0, 0);
            btnDelete.Size = new Size(262, 94);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // User_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 485);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "User_Form";
            Text = "User_Form";
            Load += User_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void BtnNext_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel5;
        private Button btnPrevious;
        private Panel panel4;
        private Button BtnNext;
        private Panel panel3;
        private Button btnDelete;
    }
}