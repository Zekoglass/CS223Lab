using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlconn
{
    internal class connection
    {

        


        public SqlConnection sqlConnection { get; set; }
        public SqlCommand sqlCommand = null;

        public connection (SqlCommand sqlCommand)
        {
            //this.sqlConnection = sqlConnection;
            this.sqlCommand = sqlCommand;
        }
        public connection()
        {
           
        }

        public int ExecuteNonQuery(string query)
        {
            SqlConnection connection = Connection();
            int result = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                //Product p = new Product();
                //cmd.Parameters.AddWithValue("@ObjectName",p.OBJ_NAME);
                //cmd.Parameters.AddWithValue("@ProdDate", p.OBJ_NAME);
                //cmd.Parameters.AddWithValue("@InventoryNumber", p.OBJ_NAME);
                //cmd.Parameters.AddWithValue("@Quantity", p.OBJ_NAME);
                //cmd.Parameters.AddWithValue("@Price", p.OBJ_NAME);
                //cmd.Parameters.AddWithValue("@ProductType", p.OBJ_NAME);
                // cmd.Parameters.AddWithValue("@Numbers", p.OBJ_NAME);
                //cmd.Parameters.AddWithValue("@isAvailable", p.OBJ_NAME);

                result = cmd.ExecuteNonQuery();
                


               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            return result;
        }

        public int ExecuteScalar(string query)
        {
            SqlConnection connection = Connection();
            int result = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                result = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (connection != null)
                connection.Close();
            return result;
        }

        public SqlDataReader ExecuteReader(string query)
        {
            /*
             * The connection is not closed in this 
             * funnction because we can not do read 
             * operation on sqlDataReader after the 
             * connetion is closed.
             */
            sqlConnection = Connection();
            SqlDataReader result = null;
            try
            {
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                result = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }





        public SqlConnection Connection()
        {
            SqlConnection connection = null;
            try
            {
                string connectionString = @"Data source =.; Initial Catalog =C#LAB; Integrated Security = True;";
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return connection;
        }



    }
}
