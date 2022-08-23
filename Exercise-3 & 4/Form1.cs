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

        public static Form1 instance1;
        public string user;
        public DataGridView Dts;
        public int i =0;
        public Form1()
        {
            InitializeComponent();
            instance1 = this;
            uname.Text = Form2.user;
            //MessageBox.Show(Form2.user);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idnum.Text == "")
                MessageBox.Show("Product Name can't be empty");
            else if (string.IsNullOrEmpty(invnum.Text))
                errorProvider1.SetError(invnum, "inventory number is Required");
            else
            {
                errorProvider1.Clear();

                product pro = new product();

                pro.Product_Discription = objName.Text;

                pro.inventorynumber =invnum.Text;

                pro.ProductName = idnum.Text;

                pro.date = dpicker.Value.ToString();

                pro.Amount = int.Parse(cnt.Text);

                pro.price = PriceBox.Text;

                pro.Available= Available.Checked;

                pro.Not_Available = NotAvailable.Checked;

                RadioButton chk =Gender.Controls.OfType<RadioButton>()

                    .FirstOrDefault(r => r.Checked == true);
                //MessageBox.Show(chk.Name );

                pro.save();

                objName.Clear();
                invnum.Clear();
                idnum.Clear(); 
                cnt.Clear();
                PriceBox.Clear();
                Available.Checked = false;   
                NotAvailable.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
