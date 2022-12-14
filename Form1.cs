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
        public Form1(string NAME)
        {
            InitializeComponent();
            current_user.Text = NAME;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            /*Product p = new Product();
            p.NUMBER = Convert.ToDouble(numberrr.Text);
            p.INVO_NUM = Convert.ToDouble(inv_numberrr.Text);
            p.OBJ_NAME = Convert.ToString( obj_nameee.Text);
            p.DATE =Convert.ToDateTime( dateee.Value);
            p.PRICE = Convert.ToDouble(priceee.Text);
            p.COUNT = Convert.ToDouble(Counttt.Text);
            p.isAvailable =Convert.ToBoolean( cBisAva.Checked);
            p.add();
            */


            Product p = new Product();
            Regex rxForInventoryNumber = new Regex(@"^[0-9]{6}$");

            bool allFieldsAreCorrect = true;
            errorProvider1.Clear();

            if (rxForInventoryNumber.IsMatch(numberrr.Text))
            {
                p.NUMBER = int.Parse(numberrr.Text);
            }
            else
            {
                allFieldsAreCorrect = false;
                errorProvider1.SetError(numberrr, "The field should be 6 digite whole number.");
            }


            if (rxForInventoryNumber.IsMatch(inv_numberrr.Text))
            {
                p.INVO_NUM = int.Parse(inv_numberrr.Text);
            }
            else
            {
                allFieldsAreCorrect = false;
                errorProvider1.SetError(inv_numberrr, "The field should be 6 digite whole number.");
            }




            p.DATE = dateee.Value;



            for (int i = 0; i < obj_nameee.Text.Length; i++)
            {
                if (((obj_nameee.Text[i] >= 'A' && obj_nameee.Text[i] <= 'Z') || (obj_nameee.Text[i] >= 'a' && obj_nameee.Text[i] <= 'z') || (obj_nameee.Text[i] >= '0' && obj_nameee.Text[i] <= '9') || (obj_nameee.Text[i] == ' ' || obj_nameee.Text[i] == '_')) == false)
                {
                    allFieldsAreCorrect = false;
                    errorProvider1.SetError(obj_nameee, "The field should only contain alphabet, number, space and underscore('_').");
                    break;
                }
            }
            p.OBJ_NAME = obj_nameee.Text;



            try
            {
                p.COUNT = int.Parse(Counttt.Text);

            }
            catch (Exception)
            {
                allFieldsAreCorrect = false;
                errorProvider1.SetError(Counttt, "The field should contain number.");
            }



            try
            {
                p.PRICE = decimal.Parse(priceee.Text);
            }
            catch (Exception)
            {
                allFieldsAreCorrect = false;
                errorProvider1.SetError(priceee, "The field should contain number(it can be decimal number).");
            }



            p.isAvailable = cBisAva.Checked;

            if (rbsimple.Checked == false && cBisAva.Checked == false)
            {
                allFieldsAreCorrect = false;
                errorProvider1.SetError(gBoxPType, "One of the radio buttons should be selected.");

            }



            p.ProductType = (rbvariable.Checked == true) ? "variable" : "simple";

            if (allFieldsAreCorrect == true)
            {
                int numberOfRowAffected = p.add();
                if (numberOfRowAffected == 1)
                {
                    MessageBox.Show($"Product is Saved Sucessfully.");
                }

                
                dgview.DataSource = null;
                dgview.DataSource = Product.GetAllProducts();

            }












        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cLBProductC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateee_ValueChanged(object sender, EventArgs e)
        {

        }

        private void priceee_TextChanged(object sender, EventArgs e)
        {

        }

        private void Counttt_TextChanged(object sender, EventArgs e)
        {

        }

        private void obj_nameee_TextChanged(object sender, EventArgs e)
        {

        }

        private void inv_numberrr_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberrr_TextChanged(object sender, EventArgs e)
        {

        }

        private void P_Click(object sender, EventArgs e)
        {

        }

        private void C_Click(object sender, EventArgs e)
        {

        }

        private void O_Click(object sender, EventArgs e)
        {

        }

        private void I_Click(object sender, EventArgs e)
        {

        }

        private void D_Click(object sender, EventArgs e)
        {

        }

        private void n_Click(object sender, EventArgs e)
        {

        }

        private void gBoxAva_Enter(object sender, EventArgs e)
        {

        }
    }
}
