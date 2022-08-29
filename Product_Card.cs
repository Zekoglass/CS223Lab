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
    public partial class Product_Card : UserControl
    {
        public Product_Card()
        {
            InitializeComponent();
        }

        private string _Productname;


        public string Productname
        {
            get { return _Productname; }
            set { _Productname = value; Name_label.Text += value; }
        }

        private string _ProductDescription;

        public string ProductDescription
        {
            get { return _ProductDescription; }
            set { _ProductDescription = value; dESC_label.Text += value; }
        }

        private string _ProductPrice;

        public string ProductPrice
        {
            get { return _ProductPrice; }
            set { _ProductPrice = value; Price_label.Text += value; }
        }












    }
}
