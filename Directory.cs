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
    public partial class Directory : Form
    {
        public Directory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_Mid.BackColor = Color.Aquamarine;
            Indicater_panel.Location = new Point(Indicater_panel.Location.X, 109);

        }

        private void upadteButton_Click(object sender, EventArgs e)
        {
            panel_Mid.BackColor = Color.DarkOliveGreen;
            Indicater_panel.Location = new Point(Indicater_panel.Location.X, 173);

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            panel_Mid.BackColor = Color.Red;
            Indicater_panel.Location = new Point(Indicater_panel.Location.X, 224);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            panel_Mid.BackColor = Color.Black;
            Indicater_panel.Location = new Point(Indicater_panel.Location.X, 281);
            
            this.Close();
        }

        private void pListButton_Click(object sender, EventArgs e)
        {
            if (this.PList_flowLayoutPanel.Controls.Count > 0)
                this.PList_flowLayoutPanel.Controls.RemoveAt(0);

            panel_Mid.BackColor = Color.CadetBlue;
            Indicater_panel.Location = new Point(Indicater_panel.Location.X, 334);


            foreach (Control item in PList_flowLayoutPanel.Controls.OfType<Product_Card>().ToList())
            {
                PList_flowLayoutPanel.Controls.Remove(item);
            }
            foreach (var item in Product.GetAllProducts())
            {
                Product_Card card = new Product_Card();
                card.Productname = item.OBJ_NAME;
                card.ProductDescription = Convert.ToString(item.COUNT);
                card.ProductPrice =Convert.ToString(item.PRICE);
                PList_flowLayoutPanel.Controls.Add(card);
                card.Show();
            }

        }

        private void Directory_Load(object sender, EventArgs e)
        {
            foreach (var item in Product.GetAllProducts())
            {
                Product_Card card = new Product_Card();
                card.Productname = item.OBJ_NAME;
                card.ProductDescription = Convert.ToString(item.COUNT);
                card.ProductPrice = Convert.ToString(item.PRICE);
                PList_flowLayoutPanel.Controls.Add(card);
                card.Show();
            }
        }

        private void product_Card1_Load(object sender, EventArgs e)
        {

        }
    }
}
