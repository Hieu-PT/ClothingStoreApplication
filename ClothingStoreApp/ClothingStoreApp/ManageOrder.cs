using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreApp
{
    class ManageOrder
    {
        string strConnection;

        public ManageOrder()
        {
            strConnection = getConnectionString();
        }

        public string getConnectionString()
        {
            string strConnection = "Data Source=localhost,1433;Initial Catalog=FashionApp;User ID=sa;Password=hieu123";
            return strConnection;
        }
        public int addNewOrder(string CusName, double Total)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "Insert into [dbo].[tblOrder] values(@CusName,@Total,@Status);SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@CusName", CusName);
            cmd.Parameters.AddWithValue("@Total", Total);
            cmd.Parameters.AddWithValue("@Status","Pending");
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count;
        }

        public bool addNewOrderDetails(int OrderID, string ItemID, string ItemName, double ItemPrice, int ItemQuantity)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "Insert into [dbo].[tblOrderDetails] values(@OrderID,@ItemID,@ItemName,@ItemPrice,@ItemQuantity)";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@OrderID", OrderID);
            cmd.Parameters.AddWithValue("@ItemID", ItemID);
            cmd.Parameters.AddWithValue("@ItemName", ItemName);
            cmd.Parameters.AddWithValue("@ItemPrice", ItemPrice);
            cmd.Parameters.AddWithValue("@ItemQuantity", ItemQuantity);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
    }
}
