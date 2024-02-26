using Autofac;
using Autofac.Core;
using SmartShop.Application1.Services;
using SmartShop.Model.Model;
using SmartShop.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Markt.Presentation
{
    public partial class OrdersForm : Form
    {
        int Page = 0;
        IOrderServices orderServices;
        public OrdersForm()
        {
            InitializeComponent();
            var container = AutoFac.Inject();
            orderServices = container.Resolve<IOrderServices>();
            show();
        }
        private void OrdersForm_Load(object sender, EventArgs e)
        {
            comState.DataSource = new object[] { "processing", "shipped", "delivered" };
        }
        public void show(int pageNumber = 0)
        {
            if (pageNumber >= 0)
            {
                var data = orderServices.GetAllPagination(pageNumber, 10).ToList();

                if (data.Count > 0)
                    dataGridView1.DataSource = data;
                else
                {
                    Page = 0;
                    dataGridView1.DataSource = orderServices.GetAllPagination(0, 10).ToList();
                }
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {

            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            //Order order = orderServices.GetOrder(id);
            //order.Order_Status = comState.SelectedValue.ToString();
            //orderServices.UpdateOrder(order);
            show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Page++;
            show(Page);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Page--;
            show(Page);
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            //Order order = orderServices.GetOrder(id);
            //orderServices.DeleteOrder(order);
            show();
        }


    }
}
