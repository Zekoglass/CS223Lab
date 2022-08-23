using System;
using System.Text.RegularExpressions;
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


            Regex A = new Regex(@"^[a-z]||[A-Z] {10}$");
            Regex B = new Regex(@"[0-9]{5}$");


            if (string.IsNullOrEmpty(numberrr.Text))
            {

                errorProvider1.SetError(numberrr, "INVALID number- !  ");
            }
            else if (B.IsMatch(numberrr.Text))
            {
                errorProvider1.SetError(numberrr, "INVALID number- !  ");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (string.IsNullOrEmpty(Counttt.Text))
            {

                errorProvider1.SetError(Counttt, "INVALID Count !  ");
            }
            else if (B.IsMatch(Counttt.Text))
            {
                errorProvider1.SetError(Counttt, "INVALID Count !  ");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (string.IsNullOrEmpty(obj_nameee.Text))
            {

                errorProvider1.SetError(obj_nameee, "INVALID ObjectName  !  ");
            }
            else if (A.IsMatch(obj_nameee.Text))
            {
                errorProvider1.SetError(obj_nameee, "INVALID ObjectName !  ");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (string.IsNullOrEmpty(inv_numberrr.Text))
            {

                errorProvider1.SetError(inv_numberrr, "INVALID InvetoryNUM  !  ");
            }
            else if (B.IsMatch(inv_numberrr.Text))
            {
                errorProvider1.SetError(inv_numberrr, "INVALID InvetoryNUM !  ");
            }
            else
            {
                errorProvider1.Clear();
            }

            try
            {
                if (string.IsNullOrEmpty(priceee.Text))
                {

                    errorProvider1.SetError(priceee, "INVALID Price  ! ");
                }
                else
                {
                    errorProvider1.Clear();
                    p.add();
                    MessageBox.Show("Sucessfully Added");
                    dgview.DataSource = null;
                    dgview.DataSource = Product.GetAllProducts();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Price  ! ");
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
