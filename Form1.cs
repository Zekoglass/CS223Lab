using System;
using System.Windows.Forms;

namespace sqlconn
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.NUMBER = Convert.ToInt32(numberrr.Text);
            p.INVO_NUM = Convert.ToInt32(inv_numberrr.Text);
            p.OBJ_NAME = obj_nameee.Text;
            p.DATE = dateee.Text;
            p.PRICE = Convert.ToDouble(priceee.Text);
            p.COUNT = Convert.ToInt32(Counttt.Text);
            p.add();


        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
