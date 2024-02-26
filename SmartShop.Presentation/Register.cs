using Autofac;
using SmartShop.Application1.Services;
using SmartShop.Dtos.Dtos;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var container = AutoFac.Inject();
            IUserServices userServices = container.Resolve<IUserServices>();
            string FName = Fname.Text;
            string LName = Lname.Text;
            string email = Email.Text;
            string userName = UserName.Text;
            string password = Password.Text;
            string phone = Phone.Text;
            string address = Address.Text;
            UserDtos user = userServices.FindUser(userName, password);
            UserDtos user1 = new UserDtos();

            if (user != null && user.UserName == userName && user.Email == email)
            {
                MessageBox.Show("UserName or Email already Exist !");
            }
            else
            {


                if (FName != "" && LName != "" && email != "" && userName != "" && password != "" && phone != "" && address != "")
                {
                    user1.FirstName = FName;
                    user1.LastName = LName;
                    user1.Email = email;
                    user1.UserName = userName;
                    user1.Password = password;
                    user1.Phone = phone;
                    user1.Address = address;
                    userServices.AddUser(user1);

                }

                else
                {
                    MessageBox.Show("No Data To Regist", "Error");

                }
            }


        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Fname.Clear();
            Lname.Clear();
            Email.Clear();
            UserName.Clear();
            Password.Clear();
            Phone.Clear();
            Address.Clear();

        }

    }
}
