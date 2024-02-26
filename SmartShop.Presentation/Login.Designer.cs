namespace SmartShop.Presentation
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            ClearBotton = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel = new Panel();
            panel4 = new Panel();
            LoginButton = new Button();
            panel.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // ClearBotton
            // 
            ClearBotton.BackColor = Color.FromArgb(0, 0, 0, 255);
            ClearBotton.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            ClearBotton.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            ClearBotton.FlatStyle = FlatStyle.Flat;
            ClearBotton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ClearBotton.ForeColor = Color.FromArgb(255, 64, 85);
            ClearBotton.Image = (Image)resources.GetObject("ClearBotton.Image");
            ClearBotton.ImageAlign = ContentAlignment.MiddleLeft;
            ClearBotton.Location = new Point(-13, -14);
            ClearBotton.Margin = new Padding(0);
            ClearBotton.Name = "ClearBotton";
            ClearBotton.Padding = new Padding(30, 0, 0, 0);
            ClearBotton.Size = new Size(272, 94);
            ClearBotton.TabIndex = 1;
            ClearBotton.Text = "Clear";
            ClearBotton.UseVisualStyleBackColor = false;
            ClearBotton.Click += ClearBotton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(85, 85, 84);
            label1.Location = new Point(49, 62);
            label1.Name = "label1";
            label1.Size = new Size(158, 38);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(85, 85, 84);
            label2.Location = new Point(49, 169);
            label2.Name = "label2";
            label2.Size = new Size(136, 38);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(229, 55);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 34);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(229, 169);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(377, 34);
            textBox2.TabIndex = 4;
            // 
            // panel
            // 
            panel.Controls.Add(ClearBotton);
            panel.Location = new Point(111, 342);
            panel.Name = "panel";
            panel.Size = new Size(206, 71);
            panel.TabIndex = 45;
            // 
            // panel4
            // 
            panel4.Controls.Add(LoginButton);
            panel4.Location = new Point(381, 336);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 77);
            panel4.TabIndex = 44;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(0, 0, 0, 255);
            LoginButton.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            LoginButton.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.Teal;
            LoginButton.Image = (Image)resources.GetObject("LoginButton.Image");
            LoginButton.ImageAlign = ContentAlignment.MiddleLeft;
            LoginButton.Location = new Point(-6, -2);
            LoginButton.Margin = new Padding(4);
            LoginButton.Name = "LoginButton";
            LoginButton.Padding = new Padding(30, 0, 0, 0);
            LoginButton.Size = new Size(290, 84);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 239, 239);
            ClientSize = new Size(750, 476);
            Controls.Add(panel);
            Controls.Add(panel4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Login";
            Text = "User Login Form";
            panel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel;
        private Panel panel4;
        private Button LoginButton;
        private Button ClearBotton;
    }
}

