using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreApp
{
    class ManageAccount
    {
        private string strConnection;
        private SqlConnection con;
        public ManageAccount()
        {
            strConnection = getConnectionString();
        }
        public string getConnectionString()
        {
            string strConnection = "Data Source=localhost,1433;Initial Catalog=FashionApp;User ID=sa;Password=hieu123";
            return strConnection;
        }

        public void CheckConnectionState()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public bool insertAccount(Customer cus)
        {
            bool check = false;
            try
            {
                con = new SqlConnection(strConnection);
                string sql = "INSERT INTO Customer(username, password, isAdmin) " +
                                "VALUES (@username, @password, @role)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@username", cus.username);
                cmd.Parameters.AddWithValue("@password", cus.password);
                cmd.Parameters.AddWithValue("@role", false);
                CheckConnectionState();
                check = cmd.ExecuteNonQuery() > 0;
            } finally
            {
                con.Close();
            }
            return check;
        }

        public Customer FindByPrimaryKey(string Key)
        {
            Customer cus = null;
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "Select Username From Customer Where Username = @Key";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@Key", Key);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string Name = reader.GetString(reader.GetOrdinal("Username"));
                cus = new Customer
                {
                    username = Name
                };
            }
            return cus;
        }
    }
}
