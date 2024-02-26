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
    public partial class CustomerHome : Form
    {
        bool SidebarExpand;
        public CustomerHome()
        {
            InitializeComponent();
        }


        private void Product_Click(object sender, EventArgs e)
        {
            DisplayProduct displayProduct = new DisplayProduct();
            displayProduct.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

    }
}
