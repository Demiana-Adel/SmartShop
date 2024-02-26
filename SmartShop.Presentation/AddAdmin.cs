using Autofac;
using AutoMapper;
using SmartShop.Application1.Mapper;
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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();

        }

        bool AdminFlag = false;

        private void Add_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var container = AutoFac.Inject();
            IUserServices userServices = container.Resolve<IUserServices>();
            UserDtos user = new UserDtos();
            string adminFName = AdminFname.Text;
            string adminLName = Adminname.Text;
            string email = AdminEmail.Text;
            string userName = AdminUserName.Text;
            string password = AdminPass.Text;
            string phone = AdminPhone.Text;
            string address = AdminAddress.Text;

            if (AdminFlag == true)
            {
                user.Admin = AdminFlag;
            }
            else
            {
                user.Admin = AdminFlag;
            }
            if (adminFName != "" && adminLName != "" && email != "" && userName != "" && password != "" && phone != "" && address != "")
            {
                user.FirstName = adminFName;
                user.LastName = adminLName;
                user.Email = email;
                user.UserName = userName;
                user.Password = password;
                user.Phone = phone;
                user.Address = address;
                userServices.AddUser(user);
            }
            else
            {
                MessageBox.Show("No Data To Add", "Error");

            }

        }



        private void AdminRoleT_CheckedChanged(object sender, EventArgs e)
        {
            AdminFlag = true;
        }

        private void AdminRoleF_CheckedChanged(object sender, EventArgs e)
        {
            AdminFlag = false;
        }

        private void Clear_Click1(object sender, EventArgs e)
        {
            AdminFname.Clear();
            Adminname.Clear();
            AdminEmail.Clear();
            AdminAddress.Clear();
            AdminUserName.Clear();
            AdminPhone.Clear();
            AdminPass.Clear();
            AdminRoleT.Checked = false;
            AdminRoleF.Checked = false;


        }

    }
}
