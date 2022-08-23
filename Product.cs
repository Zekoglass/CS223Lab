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
        public string DATE { get; set; }
        public double PRICE { get; set; }
        public double INVO_NUM { get; set; }
        public double COUNT { get; set; }
        public string OBJ_NAME { get; set; }

        public void add()
        {
            //MessageBox.Show("Added");
            productList.Add(this);
        }

        static public List<Product> GetAllProducts()
        {
            return productList;

        }
    }
}
