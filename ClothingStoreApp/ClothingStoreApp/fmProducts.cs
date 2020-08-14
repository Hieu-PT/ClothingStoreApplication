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
    public partial class fmProducts : Form
    {
        ManageProduct mn = new ManageProduct();
        DataTable dt;
        BindingSource bs = new BindingSource();

        public fmProducts()
        {
            InitializeComponent();
            this.FormClosing += fmProducts_FormClosing;
        }

        private void fmProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void getAllProducts()
        {
            dt = mn.getProducts();
            txtProductID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            bs.DataSource = dt;
            dgvProducts.DataSource = bs;

            bindingNav.BindingSource = bs;
            txtProductID.DataBindings.Add("Text", bs, "ProductID");
            txtProductName.DataBindings.Add("Text", bs, "ProductName");
            txtPrice.DataBindings.Add("Text", bs, "ProductPrice");

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Products p = new Products
            {
                ProductID = Int32.Parse(txtProductID.Text),
                ProductName = txtProductName.Text,
                ProductPrice = double.Parse(txtPrice.Text)
            };
            if (mn.updateProduct(p))
            {
                MessageBox.Show("Update success");
            }
            else
            {
                MessageBox.Show("Update Fail");
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Products p = new Products
            {
                    ProductID = Int32.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text,
                    ProductPrice = double.Parse(txtPrice.Text)
                };
                if (mn.FindByPrimaryKey(p.ProductID.ToString()) == null)
                {
                    if (mn.addNewProduct(p))
                    {
                        MessageBox.Show("Add success");
                        getAllProducts();
                    }
                    else
                    {
                        MessageBox.Show("Add Fail");
                    }
                }
                else MessageBox.Show("This product is existed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occur, please try again later!" + ex.Message);
                //errorProvider1.SetError(txtID, ex.Message);
            }
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            fmReport rp = new fmReport();
            rp.Show();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtProductID.Text);
            if (mn.deleteProduct(id))
            {
                MessageBox.Show("Delete success");
            }
            else
            {
                MessageBox.Show("Delete Fail");
            }
        }

        private void btRefesh_Click(object sender, EventArgs e)
        {
            getAllProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            string filter = "ProductName like '%" + txtSearch.Text + "%'";
            dv.RowFilter = filter;
            lbsum.Text = "SumProductPrice: " + dt.Compute("SUM(ProductPrice)", filter);
        }

        private void fmProducts_Load(object sender, EventArgs e)
        {
            getAllProducts();
            DataView dv = dt.DefaultView;
            string filter = "ProductName like '%" + txtSearch.Text + "%'";
            dv.RowFilter = filter;
            lbsum.Text = "Sum Product Price: " + dt.Compute("SUM(ProductPrice)", filter);
        }

        private void fmProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
