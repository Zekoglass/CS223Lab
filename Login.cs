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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            //string Email = uName.Text;
            //string Password = pWord.Text;

            if ((this.uName.Text == "Admin") && (this.pWord.Text == "Admin"))
            {
                this.Hide();
                Directory form =new Directory();
                //Main form = new Main(Email);
                // Form1 form = new Form1(Email);
                //MessageBox.Show("you are granted access");
                //form.ShowDialog();
                form.Show();

            }
            else
            {
                MessageBox.Show(" incorrect ");
            }

        }

        private void cancButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
