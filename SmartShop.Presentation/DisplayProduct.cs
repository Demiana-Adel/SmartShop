using Autofac;
using SmartShop.Application1.Services;
using SmartShop.Dtos.Dtos;
using SmartShop.Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartShop.Presentation
{
    public partial class DisplayProduct : Form
    {
        static List<ProductDtos> products_Card1 = new List<ProductDtos>();
        //crad grid view list (quantity)
        List<ProductDtos> products_Card2 = new List<ProductDtos>();
        static int pages = 0;
        decimal sum = 0;

        IProductServices productServices;
        IOrderServices orderServices;

        public DisplayProduct()
        {
            InitializeComponent();
            var container = AutoFac.Inject();
            productServices = container.Resolve<IProductServices>();
            orderServices = container.Resolve<IOrderServices>();
        }

        public void show()
        {
            var data = productServices.GetAllPagination(pages, 15).Select(p => new
            {
                p.Name,
                p.Description,
                p.Price,
                p.ProductQuantity,


            }).ToList();
            if (data.Count > 0)
                dataGridView1.DataSource = data;
        }
        public void show(int page_Number)
        {
            if (page_Number >= 0)
                dataGridView1.DataSource = productServices.GetAllPagination(page_Number, 15).Select(p => new
                {
                    p.Name,
                    p.Description,
                    p.Price,
                    p.ProductQuantity,


                }).ToList();
            else
                show();

        }
        private void DisplayProduct_Load(object sender, EventArgs e)
        {
            show();
        }

        // Next Page Button
        private void btnNext_Click(object sender, EventArgs e)
        {
            show();
            var Number_Of_products = productServices.GetAllPagination(pages, 15)
                .Select(p=>new
                {
                   p.Name,
                   p.Description,
                   p.Price,
                   p.ProductQuantity,
                    
                    
                }).ToList();
            if (Number_Of_products.Count > 0)
                pages++;
        }
        // Show Prevoiuse Page Button

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pages > 0)
            {
                pages--;
                show();
            }
        }


        private void btnAddToCard_Click(object sender, EventArgs e)
        {

            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            string name = Convert.ToString(selectedRow.Cells["Name"].Value);
            ProductDtos Selected_product = productServices.SearchByName(name).FirstOrDefault();
            MessageBox.Show(Selected_product.Name);

            if (Selected_product.ProductQuantity > 0)
            {
                Selected_product.ProductQuantity = Selected_product.ProductQuantity - 1;

                productServices.UpdateProduct(Selected_product);


                products_Card1.Add(Selected_product);
                show(pages - 1);
                // deep copy of product to use it in card
                ProductDtos Selected_product_Copy = new ProductDtos()
                {
                    ID = Selected_product.ID,
                    Name = Selected_product.Name,
                    Price = Selected_product.Price,
                    Description = Selected_product.Description,
                    ProductQuantity = 1
                };
                // check the user choose the selected product before or not 
                var existingProduct = products_Card2.FirstOrDefault(o => o.Name == Selected_product.Name);

                if (existingProduct != null)
                    existingProduct.ProductQuantity += 1;

                else
                {
                    Selected_product_Copy.ProductQuantity = 1;
                    products_Card2.Add(Selected_product_Copy);
                }

                MessageBox.Show("Add To Card");
                sum += Selected_product.Price;
                txtPrice.Text = sum.ToString();
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = products_Card2.Select(p => new
                {
                    p.Name,
                    p.Description,
                    p.Price,
                    p.ProductQuantity,

                }).ToList();
            }
            else
                MessageBox.Show("Out Of Stock");

        }




        private void btnDeleteFromCard_Click(object sender, EventArgs e)
        {

            if (products_Card1.Count > 0)
            {
                int rowIndex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[rowIndex];
                string name = Convert.ToString(selectedRow.Cells["Name"].Value);
                ProductDtos Selected_Product_For_Deleted = productServices.SearchByName(name).FirstOrDefault();

                Selected_Product_For_Deleted.ProductQuantity = Selected_Product_For_Deleted.ProductQuantity + 1;
                productServices.UpdateProduct(Selected_Product_For_Deleted);
                show(pages - 1);
                products_Card1.Remove(Selected_Product_For_Deleted);
                dataGridView2.DataSource = null;

                //remove product from products_Card2
                ProductDtos p2 = products_Card2.Find(p => p.Name == Selected_Product_For_Deleted.Name);

                if (p2.ProductQuantity > 1)
                    p2.ProductQuantity -= 1;
                else
                    products_Card2.Remove(p2);

                //Crad DataGridView
                dataGridView2.DataSource = dataGridView2.DataSource = products_Card2
                                                                        .Select(p => new
                                                                        {
                                                                            p.Name,
                                                                            p.Description,
                                                                            p.Price,
                                                                            p.ProductQuantity,

                                                                        }).ToList();
                sum -= Selected_Product_For_Deleted.Price;
                txtPrice.Text = sum.ToString();
                MessageBox.Show("Deleted");
            }
            else
                MessageBox.Show("The Card Is Empty Now");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text;
            if (searchName.Length == 0)
            {
                pages = 0;
                show();
            }
            List<ProductDtos> productSearch = productServices.SearchByName(searchName).ToList();
            dataGridView1.DataSource = productSearch.Select(p => new
            {
                p.Name,
                p.Description,
                p.Price,
                p.ProductQuantity,
            }).ToList();
        }


        //search By Name 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text;
            if (searchName.Length == 0)
            {
                pages = 0;
                show();
            }
            List<ProductDtos> productSearch = productServices.SearchByName(searchName).ToList();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            int userID = 6;   ///user ID we will recive it from loning form 
            decimal price = 0;

            List<OrdersItemsDtos> orderItemsList = new List<OrdersItemsDtos>();
            foreach (var item in products_Card1)
            {
                orderItemsList.Add(new OrdersItemsDtos() { ProductID = item.ID, Quantity = 1 });
                price = price + item.Price;

            }

            // Get Current date
            string OrderDate = DateTime.Now.ToString("dd/MM/yyyy");
            DateTime orderDate = DateTime.ParseExact(OrderDate, "dd/MM/yyyy", null);

            OrderDtos newOrder = new OrderDtos()
            {
                UserID = userID,
                Items = orderItemsList,
                TotalPrice = price,
                OrderDate = orderDate,
                Order_Status = "processing"

            };
            orderServices.AddOrder(newOrder);
            MessageBox.Show("Oder confirmed");


        }
    }
}
