using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace sqlconn
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {

            dgview.DataSource = null;
            dgview.DataSource = Product.GetAllProducts();


            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
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
                int numberOfRowAffected = p.update();
                if (numberOfRowAffected == 1)
                {
                    MessageBox.Show($"Product is updated Sucessfully.");
                }


                dgview.DataSource = null;
                dgview.DataSource = Product.GetAllProducts();

            }
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
