using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingStoreApp
{
    public partial class fmChangeAccount : Form
    {
        Customer cus;
        public fmChangeAccount(Customer customer)
        {
            InitializeComponent();
            cus = customer;
            txtID.Text = cus.username;
            txtPass.Text = cus.password;
            txtRole.Text = cus.isRole;
            //this.FormClosing += fmChangeAccount_FormClosing;
        }

        /*private void fmChangeAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }*/

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (!txtPass.Text.Equals(""))
            {
                ManageProduct mp = new ManageProduct();
                cus.isRole = txtPass.Text;
                if (mp.UpdateCustomer(cus))
                {
                    MessageBox.Show("Update success");
                }
                else
                {
                    MessageBox.Show("Update success");
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            fmLogin login = new fmLogin();
            login.Show();
        }
    }
}
