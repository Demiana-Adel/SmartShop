using Markt.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartShop.Presentation
{
    public partial class AdminHome : Form
    {
        bool SidebarExpand;
        public AdminHome()
        {
            InitializeComponent();
        }

        private void category_Click(object sender, EventArgs e)
        {

            Categories categories = new Categories();
            categories.Show();
        }

        private void Product_Click(object sender, EventArgs e)
        {

            ProductForm productForm = new ProductForm();
            productForm.Show();
        }

        private void Addadmin_Click(object sender, EventArgs e)
        {

            AddAdmin addAdmin = new AddAdmin();
            addAdmin.Show();
        }

        private void Homebtm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
            home.BackColor = Color.White;
        }

        private void Users_Click(object sender, EventArgs e)
        {
            User_Form userForm = new User_Form();
            userForm.Show();
        }

        private void Orsers_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
        }
    }
}

