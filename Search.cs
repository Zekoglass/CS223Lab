using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlconn
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<Product> p = new List<Product>();
            Product product = Product.findOne(SearchBox.Text);
            if (product == null)
            {
                MessageBox.Show("Product not found.", "No Result");
            }
            else
            {
                p.Add(product);
                SearchDataGridView.DataSource = null;
                SearchDataGridView.DataSource = p;
            }
        }
    }
}
