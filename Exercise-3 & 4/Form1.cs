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

        public static Form1 instance1;
        public Label user;
        public DataGridView Dts;

        public Form1()
        {
            InitializeComponent();
            instance1 = this;
            user = uname;
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
                pro.isavalable=available.Checked;
                pro.Male = gen.Checked;
                pro.female = gen2.Checked;
                RadioButton chk =Gender.Controls.OfType<RadioButton>()
                    .FirstOrDefault(r => r.Checked == true);
                MessageBox.Show(chk.Name );

                foreach (var item in availables.CheckedItems)
                {
                    MessageBox.Show(item.ToString());
                }
                pro.save();
                dataGridView1.DataSource = pro.products;
                pro.showAll();

                objName.Clear();
                invnum.Clear();
                idnum.Clear(); 
                cnt.Clear();
                available.Checked = false;
                gen.Checked = false;   
                gen2.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
