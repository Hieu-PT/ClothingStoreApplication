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
    public partial class fmReport : Form
    {
        DataTable dt;
        ManageProduct mn = new ManageProduct();
        public fmReport()
        {
            InitializeComponent();
        }

        private void fmReport_Load(object sender, EventArgs e)
        {
            dt = mn.getProductsDesc();
            dgvProduct.DataSource = dt;
        }

    }
}
