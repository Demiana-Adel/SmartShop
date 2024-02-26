using Autofac;
using Autofac.Core;
using SmartShop.Application1.Services;
using SmartShop.Model.Model;
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
    public partial class User_Form : Form
    {

        int page = 0;
        IUserServices userServices;


        public void show(int r = 0)
        {
            if (r >= 0)
            {
                var data = userServices.GetAllPagination(r, 10).ToList();


                if (data.Count > 0)
                    dataGridView1.DataSource = data;
                else
                {
                    page = 0;
                    dataGridView1.DataSource = userServices.GetAllPagination(0, 10).ToList();
                }


            }
        }
        public User_Form()
        {
            InitializeComponent();
            var container = AutoFac.Inject();
            userServices = container.Resolve<IUserServices>();

        }

        private void User_Form_Load(object sender, EventArgs e)
        {
            show();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            page++;
            show(page);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            page--;
            show(page);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            string email = Convert.ToString(selectedRow.Cells["Email"].Value);
            //function overloded
            // User u = userServices.GetUser(email);
            // GetUserByEmail
            // userServices.DeleteUser(u);
            show();

        }


    }
}
