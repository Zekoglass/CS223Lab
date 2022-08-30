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
    public partial class connectToSql : Form
    {
        public connectToSql()
        {
            InitializeComponent();
        }

        private void ConButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection con = new connection();
                con.Connection();
                MessageBox.Show(" Connected ");
                

            }
            catch (Exception)
            {
                MessageBox.Show(" Connection Error ");

                throw;
            }
        }
    }
}
