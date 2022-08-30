using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlconn
{
    internal class Product
    {
        static private List<Product> productList =new List<Product>();
        public int NUMBER { get; set; }
        public DateTime DATE { get; set; }
        public decimal PRICE { get; set; }
        public int INVO_NUM { get; set; }
        public int COUNT { get; set; }
        public string OBJ_NAME { get; set; }
        public bool isAvailable { get; set; }
        public string ProductType { get; set; }
        public List<int> catagory { get; set; } = new List<int>();


        public int add()
        {
            // productList.Add(this);
            //MessageBox.Show("Added");

            connection databaseServices = new connection();
            int productType = (this.ProductType == "simple") ? 0 : 1;
            int isAvailable = this.isAvailable ? 1 : 0;
            string quary = $"INSERT INTO Product VALUES('{this.OBJ_NAME}','{this.DATE.ToString("yyyy-MM-dd HH:mm:ss.fff")}',{this.INVO_NUM},{this.COUNT},{this.PRICE},{productType},{this.NUMBER},{isAvailable})";
            int numberOfRowAffercted = databaseServices.ExecuteNonQuery(quary);
            return numberOfRowAffercted;
        }


        public int Delete(int del)
        {
            connection databaseServices = new connection();
            int productType = (this.ProductType == "simple") ? 0 : 1;
            int isAvailable = this.isAvailable ? 1 : 0;
            string quary = $"DELETE FROM Product WHERE Product.Numbers={del}";
            int numberOfRowAffercted = databaseServices.ExecuteNonQuery(quary);
            return numberOfRowAffercted;
        }


        public int update()
        {
            connection databaseServices = new connection();
            int productType = (this.ProductType == "simple") ? 0 : 1;
            int isAvailable = this.isAvailable ? 1 : 0;
            string quary = $"UPDATE Product SET ObjectName='{this.OBJ_NAME}',ProdDate='{this.DATE.ToString("yyyy-MM-dd HH:mm:ss.fff")}',InventoryNumber={this.INVO_NUM},Quantity={this.COUNT},Price={this.PRICE},ProductType={productType},isAvailable={isAvailable} WHERE Numbers={this.NUMBER}";
            int numberOfRowAffercted = databaseServices.ExecuteNonQuery(quary);
            return numberOfRowAffercted;
        }

        static public List<Product> GetAllProducts()
        {
            //return productList;

            connection databaseServices = new connection();
            List<Product> temp = new List<Product>();
            string quary = "SELECT * FROM product";
            SqlDataReader data = databaseServices.ExecuteReader(quary);
            while (data.Read())
            {
                Product product = new Product();
                product.NUMBER = (int)data["Numbers"];
                product.OBJ_NAME = (string)data["ObjectName"];
                product.PRICE = (Decimal)data["Price"];
                product.COUNT = (int)data["Quantity"];
                product.INVO_NUM = (int)data["InventoryNumber"];
                product.isAvailable = Convert.ToBoolean(data["isAvailable"]);
                product.ProductType = (Convert.ToBoolean(data["ProductType"])) ? "variable" : "simple";
                product.DATE = DateTime.Parse((string)data["ProdDate"].ToString());
                temp.Add(product);
            }
            databaseServices.sqlConnection.Close();
            return temp;




        }

        public static Product findOne(string name)
        {

            return productList.Find(P => P.OBJ_NAME.ToLower() == name.ToLower());
            //ToLower() is used to make case insensative search. 
        }
    }
}
