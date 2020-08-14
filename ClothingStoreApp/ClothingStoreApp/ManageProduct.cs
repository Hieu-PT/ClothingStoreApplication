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
    class ManageProduct
    {
        string strConnection;

        public ManageProduct()
        {
            strConnection = getConnectionString();
        }

        public string getConnectionString()
        {
            string strConnection = "Data Source=localhost,1433;Initial Catalog=FashionApp;User ID=sa;Password=hieu123";
            return strConnection;
        }

        public DataTable getProducts()
        {
            string SQL = "select * from Products";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtProduct = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtProduct);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dtProduct;
        }

        public bool addNewProduct(Products product)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "Insert Products(ProductID, ProductName, ProductPrice, Quantity) values(@ID,@Name,@Price,100)";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", product.ProductID);
            cmd.Parameters.AddWithValue("@Name", product.ProductName);
            cmd.Parameters.AddWithValue("@Price", product.ProductPrice);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }

        public bool updateProduct(Products product)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL =
                "Update Products set ProductName=@Name, ProductPrice=@Price where ProductID=@ID";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", product.ProductID);
            cmd.Parameters.AddWithValue("@Name", product.ProductName);
            cmd.Parameters.AddWithValue("@Price", product.ProductPrice);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }

        public bool deleteProduct(int ProductID)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "Delete Products where ProductID=@ID";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", ProductID);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }

        public DataTable getProductsDesc()
        {
            string SQL = "select * from Products order by ProductPrice desc";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtProduct = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtProduct);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dtProduct;
        }

        public bool UpdateCustomer(Customer cus)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL =
                "Update Customer set password = @Pass where username=@Username";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", cus.username);
            cmd.Parameters.AddWithValue("@Username", cus.password);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }

        public Products FindByPrimaryKey(string Key)
        {
            Products pro = null;
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "Select ProductName From Products Where ProductID = @ID";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", Key);
            if(cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string Name = reader.GetString(reader.GetOrdinal("ProductName"));
                pro = new Products
                {
                    ProductID = Int32.Parse(Key),
                    ProductName = Name
                };
            }
            return pro;
        }

        public DataTable getProductsLikeName(string Name)
        {
            string SQL = "select * from Products Where ProductName LIKE @Name";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@Name", "%" + Name + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtProduct = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtProduct);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dtProduct;
        }


    }


}
