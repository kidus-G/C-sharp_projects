using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Tutorial
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < product.GetAllproducts().Count; i++)
			{
                var item = product.GetAllproducts();

                productcard p = new productcard();
                p.Product = item[i].ProductName;
                p.Inventorynumber = item[i].inventorynumber;
                p.Price = item[i].price;

                p.Click += card_click;

                flowLayoutPanel1.Controls.Add(p);
            }
        }
        private void card_click(object sender, EventArgs e)
        {
            MessageBox.Show("there is something here");
        }

    }
}
