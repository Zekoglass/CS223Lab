using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlconn
{
    internal class Product
    {
        static private List<Product> productList =new List<Product>();
        public double NUMBER { get; set; }
        public DateTime DATE { get; set; }
        public double PRICE { get; set; }
        public double INVO_NUM { get; set; }
        public double COUNT { get; set; }
        public string OBJ_NAME { get; set; }
        public bool isAvailable { get; set; }
        public string ProductType { get; set; }
        public List<int> catagory { get; set; } = new List<int>();


        public void add()
        {
            productList.Add(this);
            //MessageBox.Show("Added");

        }

        static public List<Product> GetAllProducts()
        {
            return productList;

        }
        public static Product findOne(string name)
        {
            
            return productList.Find(P => P.OBJ_NAME.ToLower() == name.ToLower());
            //ToLower() is used to make case insensative search. 
        }
    }
}
