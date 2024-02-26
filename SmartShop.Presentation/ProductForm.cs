
using Autofac;
using AutoMapper;
using SmartShop.Application1.Mapper;
using SmartShop.Application1.Services;
using SmartShop.Dtos.Dtos;
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

    public partial class ProductForm : Form
    {
        int row = 0;
        IProductServices productServices;
        ICategoryServices categoryServices;

        public void showdata()
        {
            if (row >= 0)
                dataGridView1.DataSource = dataGridView1.DataSource = productServices.GetAllPagination(row, 15).ToList();
        }






        public ProductForm()
        {
            InitializeComponent();
            var container = AutoFac.Inject();
            categoryServices = container.Resolve<ICategoryServices>();
            productServices = container.Resolve<IProductServices>();





        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {



            string name = txtPName.Text;
            string discritiop = txtPDescription.Text;
            //int CatID = (int)numCatID.Value;
            int CatID = 0;
            if (comCategroy.SelectedValue != null)
            {
                CatID = (int)comCategroy.SelectedValue;
                // Now you can use selectedCategoryId as needed
                // MessageBox.Show(selectedCategoryId.ToString());
            }



            int quntity = (int)numPQuantity.Value;
            decimal price = (decimal)numPrice.Value;


            if (quntity == 0 && CatID == 0 && price == 0 && discritiop != null && name != null)
                MessageBox.Show("please Enter Product New Product");

            else
            {
                if (categoryServices.GetCategory(CatID) == null)
                    MessageBox.Show("Please enter the right Category ID");




                else
                {
                    if (quntity > 0)
                    {
                        ProductDtos product = new ProductDtos()
                        {
                            Name = name,
                            Description = discritiop,
                            Price = price,
                            CategoryID = CatID,

                            ProductQuantity = quntity
                        };
                        productServices.AddProduct(product);
                    }
                    else
                        MessageBox.Show("Quantity Must be grader than Zero");





                }
            }





            showdata();



        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            showdata();

            var categories = categoryServices.GetAllPagination(0, 50);
            comCategroy.DataSource = categories.ToList();
            comCategroy.DisplayMember = "Name";
            comCategroy.ValueMember = "ID";


        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            string name = txtPName.Text;
            string discritiop = txtPDescription.Text;
            //int CatID = (int)numCatID.Value;
            int CatID = (int)comCategroy.SelectedValue;


            int quntity = (int)numPQuantity.Value;
            decimal price = (decimal)numPrice.Value;


            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);



            ProductDtos product = productServices.GetProduct(id);


            if (name.Length > 0)
                product.Name = name;
            if (discritiop.Length > 0)
                product.Description = discritiop;
            if (price > 0)
                product.Price = price;
            if (quntity > 0)
                product.ProductQuantity = quntity;

            //////////if (CatID > 0)
            //////////    p.CategoryID = CatID;


            if (CatID > 0)
            {
                if (categoryServices.GetCategory(CatID) != null)
                    product.CategoryID = CatID;
                else
                    MessageBox.Show("Please enter the right category ID");
            }





            if (quntity == 0 && CatID == 0 && price == 0 && discritiop.Length == 0 && name.Length == 0)
                MessageBox.Show("please Enter Product New Values for updated");


            productServices.UpdateProduct(product);


            showdata();



        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);



            if (id != 0)
            {
                ProductDtos product = productServices.GetProduct(id);

                productServices.DeleteProduct(product);
            }


            showdata();


        }

        private void btnShowNext_Click(object sender, EventArgs e)
        {
            row++;
            showdata();
        }

        private void btnshowprevious_Click(object sender, EventArgs e)
        {
            row--;
            showdata();
        }


    }
}
