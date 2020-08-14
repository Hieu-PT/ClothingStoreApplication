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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "Username can not be blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password can not be blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtPassword2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword2.Text))
            {
                e.Cancel = true;
                txtPassword2.Focus();
                errorProvider1.SetError(txtPassword2, "Password can not be blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword2, null);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string username, password, password2;
                username = txtUsername.Text;
                password = txtPassword.Text;
                password2 = txtPassword2.Text;
                if (!password.Equals(password2))
                {
                    MessageBox.Show("Password is not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    Customer cus = new Customer(username, password);
                    ManageAccount ma = new ManageAccount();
                    if (ma.FindByPrimaryKey(cus.username) == null)
                    {
                        if (ma.insertAccount(cus))
                        {
                            MessageBox.Show("Register successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Register fail");
                        }
                    }
                    else MessageBox.Show("Username " + cus.username + " is existed. Please try again with another Username");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
