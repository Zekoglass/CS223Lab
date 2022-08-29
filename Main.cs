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
    public partial class Main : Form
    {
        public string Email { get; set; }

        public Main()
        {
            InitializeComponent();
        }
        public Main(string Email)
        {
            this.Email =Email;
            InitializeComponent();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();

            }
            Form1 form = new Form1();
            form.MdiParent = this;
            form.Show();
        }

        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();

            }
            Search form = new Search();
            form.MdiParent = this;
            form.Show();
        }

        private void catagoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
