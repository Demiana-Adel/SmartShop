
using Autofac;
using AutoMapper;
using SmartShop.Application1.Mapper;
using SmartShop.Application1.Services;
using SmartShop.Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmartShop.Presentation
{
    public partial class Login : Form
    {

        IUserServices userServices;
        public Login()
        {

            InitializeComponent();
            var container = AutoFac.Inject();
            userServices = container.Resolve<IUserServices>();

        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            var password = textBox2.Text;

            var user = userServices.FindUser(username, password);

            if (user != null && user.UserName == username && user.Password == password)
            {
                if (user.Admin == true)
                {

                    this.Hide();
                    AdminHome adminHome = new AdminHome();
                    adminHome.Show();
                }
                else if (user.Admin == false)
                {

                    this.Hide();
                    CustomerHome customerHome = new CustomerHome();
                    customerHome.Show();
                }
            }

            else
            {
                MessageBox.Show("Invalid Username or Password", "Error");
            }
        }

        private void ClearBotton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }



    }
}
