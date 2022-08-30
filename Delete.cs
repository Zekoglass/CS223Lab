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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            dgview.DataSource = null;
            dgview.DataSource = Product.GetAllProducts();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int del = int.Parse(deleteNum.Text);
            Product p=new Product();
            

            int numberOfRowAffected = p.Delete(del);
            if (numberOfRowAffected == 1)
            {
                MessageBox.Show($"Product is deleted Sucessfully.");
            }

            dgview.DataSource = null;
            dgview.DataSource = Product.GetAllProducts();

        }
    }
}
