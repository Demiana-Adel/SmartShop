
using Autofac;
using AutoMapper;
using SmartShop.Application1.Mapper;
using SmartShop.Application1.Services;
using SmartShop.Dtos.Dtos;
using SmartShop.Model.Model;


namespace SmartShop.Presentation
{
    public partial class Categories : Form
    {


        ICategoryServices categoryServices;
        public Categories()
        {
            InitializeComponent();
            this.Hide();
            var container = AutoFac.Inject();
            categoryServices = container.Resolve<ICategoryServices>();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = categoryServices.GetAllPagination(0, 10).ToList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CategoryName = textBox1.Text;

            if (!string.IsNullOrEmpty(CategoryName))
            {
                CategoryDtos category = new CategoryDtos() { Name = CategoryName };

                categoryServices.AddCategory(category);
            }
            else
                MessageBox.Show("Please Enter new Category Name");



            dataGridView1.DataSource = categoryServices.GetAllPagination(0, 10).ToList();



        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string CategoryName = textBox1.Text;
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            CategoryDtos category = categoryServices.GetCategory(id);///
            category.Name = CategoryName;
         
            categoryServices.UpdateCategory(category);////


            //else
            //    MessageBox.Show("Please enter the new category name");


            dataGridView1.DataSource = categoryServices.GetAllPagination(0, 10).ToList();


        }


        private async void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            CategoryDtos category = categoryServices.GetCategory(id);
            categoryServices.DeleteCategory(category);

            dataGridView1.DataSource = categoryServices.GetAllPagination(0, 10).ToList();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            textBox1.Text = selectedRow.Cells["Name"].Value.ToString();
        }
    }
}
