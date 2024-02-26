namespace SmartShop.Presentation
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel4 = new Panel();
            registbtn = new Button();
            panel3 = new Panel();
            loginbtn = new Button();
            welcom = new Label();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 0, 255);
            panel4.Controls.Add(registbtn);
            panel4.Location = new Point(12, 313);
            panel4.Name = "panel4";
            panel4.Size = new Size(337, 66);
            panel4.TabIndex = 5;
            // 
            // registbtn
            // 
            registbtn.BackColor = Color.FromArgb(0, 0, 0, 255);
            registbtn.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            registbtn.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            registbtn.FlatStyle = FlatStyle.Flat;
            registbtn.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            registbtn.ForeColor = Color.FromArgb(208, 216, 223);
            registbtn.Image = (Image)resources.GetObject("registbtn.Image");
            registbtn.ImageAlign = ContentAlignment.MiddleLeft;
            registbtn.Location = new Point(-12, -16);
            registbtn.Name = "registbtn";
            registbtn.Padding = new Padding(30, 0, 0, 0);
            registbtn.Size = new Size(362, 102);
            registbtn.TabIndex = 1;
            registbtn.Text = "      SignUp";
            registbtn.TextAlign = ContentAlignment.MiddleLeft;
            registbtn.UseVisualStyleBackColor = false;
            registbtn.Click += registbtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 0, 255);
            panel3.Controls.Add(loginbtn);
            panel3.Location = new Point(12, 184);
            panel3.Name = "panel3";
            panel3.Size = new Size(337, 66);
            panel3.TabIndex = 4;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.FromArgb(0, 0, 0, 255);
            loginbtn.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            loginbtn.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            loginbtn.ForeColor = Color.FromArgb(208, 216, 223);
            loginbtn.Image = (Image)resources.GetObject("loginbtn.Image");
            loginbtn.ImageAlign = ContentAlignment.MiddleLeft;
            loginbtn.Location = new Point(-12, -16);
            loginbtn.Name = "loginbtn";
            loginbtn.Padding = new Padding(30, 0, 0, 0);
            loginbtn.Size = new Size(362, 102);
            loginbtn.TabIndex = 1;
            loginbtn.Text = "      Login";
            loginbtn.TextAlign = ContentAlignment.MiddleLeft;
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // welcom
            // 
            welcom.AutoSize = true;
            welcom.BackColor = Color.FromArgb(0, 0, 0, 255);
            welcom.Dock = DockStyle.Top;
            welcom.FlatStyle = FlatStyle.Flat;
            welcom.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point);
            welcom.ForeColor = Color.FromArgb(208, 216, 223);
            welcom.Location = new Point(0, 0);
            welcom.Name = "welcom";
            welcom.Size = new Size(493, 133);
            welcom.TabIndex = 6;
            welcom.Text = "Welcome!";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1173, 638);
            Controls.Add(welcom);
            Controls.Add(panel4);
            Controls.Add(panel3);
            MaximizeBox = false;
            Name = "Home";
            Text = "Home";
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Panel panel4;
        private Button registbtn;
        private Panel panel3;
        private Button loginbtn;
        private Label welcom;
    }
}