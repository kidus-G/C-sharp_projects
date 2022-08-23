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
            Console.WriteLine("i was here");
            for(int i = 0; i < product.getAllproducts().Count; i++)
			{
                var item = product.getAllproducts();

                Console.WriteLine("i was here2");
                MessageBox.Show("me is here");
                productcard p = new productcard();
                p.Product = item[i].ProductName;
                p.Inventorynumber = item[i].inventorynumber;
                p.Price = item[i].price;
                MessageBox.Show(p.Product);
                flowLayoutPanel1.Controls.Add(p);
            }
        }

    }
}
