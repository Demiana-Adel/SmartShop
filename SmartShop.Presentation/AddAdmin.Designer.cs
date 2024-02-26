namespace SmartShop.Presentation
{
    partial class AddAdmin
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
            Button Clear;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdmin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            AdminFname = new TextBox();
            Adminname = new TextBox();
            AdminEmail = new TextBox();
            AdminPhone = new TextBox();
            AdminUserName = new TextBox();
            AdminPass = new TextBox();
            AdminRoleT = new RadioButton();
            panel1 = new Panel();
            AdminRoleF = new RadioButton();
            label9 = new Label();
            label7 = new Label();
            AdminAddress = new TextBox();
            panel = new Panel();
            panel4 = new Panel();
            Add = new Button();
            Clear = new Button();
            panel1.SuspendLayout();
            panel.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // Clear
            // 
            Clear.BackColor = Color.FromArgb(0, 0, 0, 255);
            Clear.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            Clear.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            Clear.FlatStyle = FlatStyle.Flat;
            Clear.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Clear.ForeColor = Color.FromArgb(255, 64, 85);
            Clear.Image = (Image)resources.GetObject("Clear.Image");
            Clear.ImageAlign = ContentAlignment.MiddleLeft;
            Clear.Location = new Point(-13, -14);
            Clear.Margin = new Padding(0);
            Clear.Name = "Clear";
            Clear.Padding = new Padding(30, 0, 0, 0);
            Clear.Size = new Size(272, 94);
            Clear.TabIndex = 1;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(85, 85, 84);
            label1.Location = new Point(30, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 38);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(85, 85, 84);
            label2.Location = new Point(627, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 38);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(85, 85, 84);
            label3.Location = new Point(30, 145);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 38);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(85, 85, 84);
            label4.Location = new Point(627, 149);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(163, 38);
            label4.TabIndex = 3;
            label4.Text = "User Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(85, 85, 84);
            label5.Location = new Point(30, 245);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(142, 38);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(85, 85, 84);
            label6.Location = new Point(627, 253);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 38);
            label6.TabIndex = 5;
            label6.Text = "Phone";
            // 
            // AdminFname
            // 
            AdminFname.Location = new Point(218, 32);
            AdminFname.Margin = new Padding(4);
            AdminFname.MaximumSize = new Size(320, 45);
            AdminFname.MinimumSize = new Size(300, 40);
            AdminFname.Name = "AdminFname";
            AdminFname.Size = new Size(305, 40);
            AdminFname.TabIndex = 7;
            // 
            // Adminname
            // 
            Adminname.Location = new Point(806, 36);
            Adminname.Margin = new Padding(4);
            Adminname.MaximumSize = new Size(330, 45);
            Adminname.MinimumSize = new Size(300, 40);
            Adminname.Name = "Adminname";
            Adminname.Size = new Size(305, 40);
            Adminname.TabIndex = 8;
            // 
            // AdminEmail
            // 
            AdminEmail.Location = new Point(218, 133);
            AdminEmail.Margin = new Padding(4);
            AdminEmail.MaximumSize = new Size(320, 45);
            AdminEmail.MinimumSize = new Size(300, 40);
            AdminEmail.Name = "AdminEmail";
            AdminEmail.Size = new Size(305, 40);
            AdminEmail.TabIndex = 9;
            // 
            // AdminPhone
            // 
            AdminPhone.Location = new Point(806, 253);
            AdminPhone.Margin = new Padding(4);
            AdminPhone.MaximumSize = new Size(330, 45);
            AdminPhone.MinimumSize = new Size(300, 40);
            AdminPhone.Name = "AdminPhone";
            AdminPhone.Size = new Size(305, 40);
            AdminPhone.TabIndex = 13;
            // 
            // AdminUserName
            // 
            AdminUserName.Location = new Point(806, 149);
            AdminUserName.Margin = new Padding(4);
            AdminUserName.MaximumSize = new Size(330, 45);
            AdminUserName.MinimumSize = new Size(300, 40);
            AdminUserName.Name = "AdminUserName";
            AdminUserName.Size = new Size(305, 40);
            AdminUserName.TabIndex = 14;
            // 
            // AdminPass
            // 
            AdminPass.Location = new Point(218, 249);
            AdminPass.Margin = new Padding(4);
            AdminPass.MaximumSize = new Size(320, 45);
            AdminPass.MinimumSize = new Size(300, 40);
            AdminPass.Name = "AdminPass";
            AdminPass.PasswordChar = '*';
            AdminPass.Size = new Size(305, 40);
            AdminPass.TabIndex = 15;
            // 
            // AdminRoleT
            // 
            AdminRoleT.AutoSize = true;
            AdminRoleT.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            AdminRoleT.ForeColor = Color.FromArgb(85, 85, 84);
            AdminRoleT.Location = new Point(133, 44);
            AdminRoleT.Margin = new Padding(4);
            AdminRoleT.Name = "AdminRoleT";
            AdminRoleT.Size = new Size(127, 42);
            AdminRoleT.TabIndex = 16;
            AdminRoleT.TabStop = true;
            AdminRoleT.Text = "Admin";
            AdminRoleT.UseVisualStyleBackColor = true;
            AdminRoleT.CheckedChanged += AdminRoleT_CheckedChanged;
            // 
            // panel1
            // 
            panel1.AccessibleDescription = "";
            panel1.AccessibleName = "";
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(AdminRoleF);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(AdminRoleT);
            panel1.Location = new Point(30, 356);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 125);
            panel1.TabIndex = 19;
            panel1.Tag = "";
            // 
            // AdminRoleF
            // 
            AdminRoleF.AutoSize = true;
            AdminRoleF.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            AdminRoleF.ForeColor = Color.FromArgb(85, 85, 84);
            AdminRoleF.Location = new Point(327, 44);
            AdminRoleF.Name = "AdminRoleF";
            AdminRoleF.Size = new Size(164, 42);
            AdminRoleF.TabIndex = 20;
            AdminRoleF.TabStop = true;
            AdminRoleF.Text = "Customer";
            AdminRoleF.UseVisualStyleBackColor = true;
            AdminRoleF.CheckedChanged += AdminRoleF_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(85, 85, 84);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(75, 38);
            label9.TabIndex = 19;
            label9.Text = "Role";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(85, 85, 84);
            label7.Location = new Point(627, 376);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(121, 38);
            label7.TabIndex = 21;
            label7.Text = "Address";
            // 
            // AdminAddress
            // 
            AdminAddress.Location = new Point(806, 376);
            AdminAddress.Margin = new Padding(4);
            AdminAddress.MaximumSize = new Size(330, 45);
            AdminAddress.MinimumSize = new Size(300, 40);
            AdminAddress.Name = "AdminAddress";
            AdminAddress.Size = new Size(305, 40);
            AdminAddress.TabIndex = 22;
            // 
            // panel
            // 
            panel.Controls.Add(Clear);
            panel.Location = new Point(304, 530);
            panel.Name = "panel";
            panel.Size = new Size(206, 71);
            panel.TabIndex = 26;
            // 
            // panel4
            // 
            panel4.Controls.Add(Add);
            panel4.Location = new Point(633, 524);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 77);
            panel4.TabIndex = 24;
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(0, 0, 0, 255);
            Add.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            Add.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Add.ForeColor = Color.FromArgb(46, 198, 151);
            Add.Image = (Image)resources.GetObject("Add.Image");
            Add.ImageAlign = ContentAlignment.MiddleLeft;
            Add.Location = new Point(-6, -2);
            Add.Margin = new Padding(4);
            Add.Name = "Add";
            Add.Padding = new Padding(30, 0, 0, 0);
            Add.Size = new Size(290, 84);
            Add.TabIndex = 1;
            Add.Text = "Add ";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // AddAdmin
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(241, 239, 239);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1162, 626);
            Controls.Add(panel);
            Controls.Add(panel4);
            Controls.Add(AdminAddress);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(AdminPass);
            Controls.Add(AdminUserName);
            Controls.Add(AdminPhone);
            Controls.Add(AdminEmail);
            Controls.Add(Adminname);
            Controls.Add(AdminFname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "AddAdmin";
            Text = "AddAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox AdminFname;
        private TextBox Adminname;
        private TextBox AdminEmail;
        private TextBox AdminPhone;
        private TextBox AdminUserName;
        private TextBox AdminPass;
        private RadioButton AdminRoleT;
        private Panel panel1;
        private Label label9;
        private Label label7;
        private TextBox AdminAddress;
        private RadioButton AdminRoleF;
        private Panel panel;
        private Panel panel4;
        private Button Add;
    }
}