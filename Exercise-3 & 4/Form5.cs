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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            dataGridView1.DataSource = product.products;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (product.products.Count == 0)
                MessageBox.Show("NO PRODUCT FOUND");
            else { 
                DialogResult result = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE", "WARRNING", buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int count = product.products.RemoveAll(p => p.ProductName == deltxt.Text);
                    if (count > 0)
                    {
                        MessageBox.Show("DELETED SUCCESFULLY");
                        dataGridView1.DataSource = product.products;
                    }
                    else
                    {
                        MessageBox.Show("UNSUCCESFULL");
                    }
                }
                else
                {
                    MessageBox.Show("Deletion has been Canceled");
                }
            }
        }
    }
}
