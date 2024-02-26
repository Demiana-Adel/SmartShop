namespace SmartShop.Presentation
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel = new Panel();
            panel4 = new Panel();
            Add = new Button();
            Address = new TextBox();
            label7 = new Label();
            Password = new TextBox();
            UserName = new TextBox();
            Phone = new TextBox();
            Email = new TextBox();
            Lname = new TextBox();
            Fname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Clear = new Button();
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
            Clear.Click += Clear_Click;
            // 
            // panel
            // 
            panel.Controls.Add(Clear);
            panel.Location = new Point(321, 507);
            panel.Name = "panel";
            panel.Size = new Size(206, 71);
            panel.TabIndex = 43;
            // 
            // panel4
            // 
            panel4.Controls.Add(Add);
            panel4.Location = new Point(650, 501);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 77);
            panel4.TabIndex = 42;
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(0, 0, 0, 255);
            Add.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            Add.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Add.ForeColor = Color.FromArgb(175, 236, 82);
            Add.Image = (Image)resources.GetObject("Add.Image");
            Add.ImageAlign = ContentAlignment.MiddleLeft;
            Add.Location = new Point(-6, -2);
            Add.Margin = new Padding(4);
            Add.Name = "Add";
            Add.Padding = new Padding(30, 0, 0, 0);
            Add.Size = new Size(290, 84);
            Add.TabIndex = 1;
            Add.Text = "SignUp";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Address
            // 
            Address.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Address.Location = new Point(222, 396);
            Address.Margin = new Padding(4);
            Address.MaximumSize = new Size(330, 45);
            Address.MinimumSize = new Size(300, 40);
            Address.Name = "Address";
            Address.Size = new Size(305, 40);
            Address.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(85, 85, 84);
            label7.Location = new Point(34, 398);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(121, 38);
            label7.TabIndex = 40;
            label7.Text = "Address";
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Password.Location = new Point(222, 279);
            Password.Margin = new Padding(4);
            Password.MaximumSize = new Size(330, 45);
            Password.MinimumSize = new Size(300, 40);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(305, 40);
            Password.TabIndex = 38;
            // 
            // UserName
            // 
            UserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            UserName.Location = new Point(821, 171);
            UserName.Margin = new Padding(4);
            UserName.MaximumSize = new Size(330, 45);
            UserName.MinimumSize = new Size(300, 40);
            UserName.Name = "UserName";
            UserName.Size = new Size(305, 40);
            UserName.TabIndex = 37;
            // 
            // Phone
            // 
            Phone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Phone.Location = new Point(821, 275);
            Phone.Margin = new Padding(4);
            Phone.MaximumSize = new Size(330, 45);
            Phone.MinimumSize = new Size(300, 40);
            Phone.Name = "Phone";
            Phone.Size = new Size(305, 40);
            Phone.TabIndex = 36;
            // 
            // Email
            // 
            Email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Email.Location = new Point(222, 163);
            Email.Margin = new Padding(4);
            Email.MaximumSize = new Size(330, 45);
            Email.MinimumSize = new Size(300, 40);
            Email.Name = "Email";
            Email.Size = new Size(305, 40);
            Email.TabIndex = 35;
            // 
            // Lname
            // 
            Lname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lname.Location = new Point(821, 56);
            Lname.Margin = new Padding(4);
            Lname.MaximumSize = new Size(330, 45);
            Lname.MinimumSize = new Size(300, 40);
            Lname.Name = "Lname";
            Lname.Size = new Size(305, 40);
            Lname.TabIndex = 34;
            // 
            // Fname
            // 
            Fname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Fname.Location = new Point(222, 62);
            Fname.Margin = new Padding(4);
            Fname.MaximumSize = new Size(330, 45);
            Fname.MinimumSize = new Size(300, 40);
            Fname.Name = "Fname";
            Fname.Size = new Size(305, 40);
            Fname.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(85, 85, 84);
            label6.Location = new Point(650, 275);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 38);
            label6.TabIndex = 32;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(85, 85, 84);
            label5.Location = new Point(34, 275);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(142, 38);
            label5.TabIndex = 31;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(85, 85, 84);
            label4.Location = new Point(646, 171);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(163, 38);
            label4.TabIndex = 30;
            label4.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(85, 85, 84);
            label3.Location = new Point(34, 171);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 38);
            label3.TabIndex = 29;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(85, 85, 84);
            label2.Location = new Point(650, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 38);
            label2.TabIndex = 28;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(85, 85, 84);
            label1.Location = new Point(34, 62);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 38);
            label1.TabIndex = 27;
            label1.Text = "First Name";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 239, 239);
            ClientSize = new Size(1193, 611);
            Controls.Add(panel);
            Controls.Add(panel4);
            Controls.Add(Address);
            Controls.Add(label7);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(Phone);
            Controls.Add(Email);
            Controls.Add(Lname);
            Controls.Add(Fname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Register";
            Text = "Register";
            panel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private Panel panel4;
        private Button Add;
        private TextBox Address;
        private Label label7;
        private TextBox Password;
        private TextBox UserName;
        private TextBox Phone;
        private TextBox Email;
        private TextBox Lname;
        private TextBox Fname;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}