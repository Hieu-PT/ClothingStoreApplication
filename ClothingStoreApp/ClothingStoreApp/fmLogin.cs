using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingStoreApp
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
            this.FormClosing += fmLogin_FormClosing;
        }

        private void fmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public Customer Login(string username, string password)
        {
            Customer cus = null; ;
            string strConnection = "Data Source=localhost,1433;Initial Catalog=FashionApp;User ID=sa;Password=hieu123";
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "select * from Customer where " +
                " username = @ID and password = @Pass";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", username);
            cmd.Parameters.AddWithValue("@Pass", password);
            SqlDataReader dr;
            try
            {
                cnn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cus = new Customer(dr.GetString(0), dr.GetString(1), dr.GetBoolean(2).ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return cus;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Customer cus = Login(txtUsername.Text, txtPassword.Text);
            if (cus != null)
            {
                if (cus.isRole.Equals("False"))
                {
                    this.Hide();
                    frmCustomer f = new frmCustomer(cus);
                    f.Show();
                }
                else
                {
                    this.Hide();
                    fmProducts f = new fmProducts();
                    f.Show();
                }

            }
            else
            {
                MessageBox.Show("Login fail.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
        }
    }
}
