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
    public partial class Form1 : Form
    {
        product pro = new product();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idnum.Text == "")
                MessageBox.Show("id number can't be empty");
            else if (string.IsNullOrEmpty(objName.Text))
                errorProvider1.SetError(objName, "Name is Required");
            else
            {
                errorProvider1.Clear();
                pro.ItemName = objName.Text;
                pro.inventorynumber =invnum.Text;
                pro.id = idnum.Text;
                pro.date = dpicker.Value.ToString();
                pro.count = Int32.Parse(cnt.Text);
                pro.save();
                pro.showAll();
            }
        }
    }
}
