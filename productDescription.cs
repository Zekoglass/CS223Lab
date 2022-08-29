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
    public partial class productDescription : UserControl
    {

        private double product_Number;
        public double ProductNumber
        {
            get { return product_Number; }
            set { product_Number = value; numLabel.Text = Convert.ToString(value); }
        }

        private DateTime product_Date;
        public DateTime ProductDate
        {
            get { return product_Date; }
            set { product_Date = value; DateLabel.Text = Convert.ToString(value); }
        }



        private double Product_InvNum;

        public double ProductInvNum
        {
            get { return Product_InvNum; }
            set { Product_InvNum = value; inv_NumLabel.Text = Convert.ToString(value); }
        }



        private string Product_ObjName;

        public string ProductObjName
        {
            get { return Product_ObjName; }
            set { Product_ObjName = value; Obj_NameLabel.Text = value; }
        }



        private string product_Type;

        public string ProductType
        {
            get { return product_Type; }
            set { product_Type = value; pTypeLabel.Text = value; }
        }

        

        private double Product_Count;

        public double ProductCount
        {
            get { return Product_Count; }
            set { Product_Count = value; CuntLabel.Text = Convert.ToString(value); }
        }



        private double product_Price;

        public double ProductPrice
        {
            get { return product_Price; }
            set { product_Price = value; priceLabel.Text = Convert.ToString(value); }
        }




        public productDescription()
        {
            InitializeComponent();
        }
    }
}
