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
    public partial class frmCustomer : Form
    {
        ManageProduct mn = new ManageProduct();
        ManageOrder mo = new ManageOrder();
        DataTable dt;
        Customer cus;
        Cart cart = new Cart();
        public frmCustomer(Customer cus)
        {
            InitializeComponent();
            this.cus = cus;
        }
        
        public void getAllProducts()
        {
            dt = mn.getProducts();
            dgvProducts.DataSource = dt;
        }

        public void ShowCart()
        {
            Dictionary<string, Products> list = cart.ShoppingCart();
            dgvCart.DataSource = list.Values.ToList();
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (KeyValuePair<string, Products> item in cart.ShoppingCart())
            {
                total += item.Value.ProductPrice * item.Value.Quantity;
            }
            return total;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            lbUser.Text = "Welcome, " + cus.username;
            getAllProducts();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmLogin f = new fmLogin();
            f.Show();
        }

        private void btAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                Products p = new Products
                {
                    ProductID = Int32.Parse(lbID.Text),
                    ProductName = lbName.Text,
                    ProductPrice = double.Parse(lbPrice.Text),
                    Quantity = Int32.Parse(txtQuantity.Value.ToString())
                };
                cart.AddToCart(p);
                ShowCart();
                txtAmount.Text = GetTotal().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occur, please try again later!");
                //errorProvider1.SetError(txtID, ex.Message);
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvProducts.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                lbID.Text = row.Cells[0].Value.ToString();
                lbName.Text = row.Cells[1].Value.ToString();
                lbPrice.Text = row.Cells[2].Value.ToString();
                txtQuantity.Value = 1;
            }
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvCart.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                lbItemID.Text = row.Cells[0].Value.ToString();
                lbItemName.Text = "Name: " + row.Cells[1].Value.ToString();
                lbItemPrice.Text = "Price: " + row.Cells[2].Value.ToString();
                txtItemQuantity.Value = Decimal.Parse(row.Cells[3].Value.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Products p = new Products
                {
                    ProductID = Int32.Parse(lbItemID.Text),
                    Quantity = Int32.Parse(txtItemQuantity.Value.ToString())
                };
                cart.Update(p);
                ShowCart();
                txtAmount.Text = GetTotal().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occur, please try again later!");
                //errorProvider1.SetError(txtID, ex.Message);
            }
        }

        private void btClearCart_Click(object sender, EventArgs e)
        {
            cart.Clear();
            ShowCart();
            txtAmount.Text = GetTotal().ToString();
        }

        private void frmCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Products p = new Products
                {
                    ProductID = Int32.Parse(lbItemID.Text)
                };
                cart.Delete(p);
                ShowCart();
                txtAmount.Text = GetTotal().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occur, please try again later!");
                //errorProvider1.SetError(txtID, ex.Message);
            }
        }

        private void btCheckOut_Click(object sender, EventArgs e)
        {
            int OrderID;
            try
            {
                if (GetTotal() > 0)
                {
                    OrderID = mo.addNewOrder(cus.username, GetTotal());
                    foreach (KeyValuePair<string, Products> item in cart.ShoppingCart())
                    {
                        mo.addNewOrderDetails(OrderID, item.Value.ProductID.ToString(), item.Value.ProductName, item.Value.ProductPrice, item.Value.Quantity);
                    }
                    MessageBox.Show("Your order has been confirmed. Thank you. Have a nice day, " + cus.username + "!");
                }
                else MessageBox.Show("Your Shopping Cart is blank. Let's shopping!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occur, please try again later!" + ex.Message);
                //errorProvider1.SetError(txtID, ex.Message);
            }
        }

        public void getAllProductsLikeName(string Name)
        {
            dt = mn.getProductsLikeName(Name);
            dgvProducts.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getAllProductsLikeName(txtSearch.Text);
        }
    }
}
