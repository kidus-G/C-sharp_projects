using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public static string user;

        public Form2()
        {
            InitializeComponent();
            instance = this;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                new mainContainer().Show();
                user = this.textBox1.Text;
                //MessageBox.Show(Form2.user);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid user name or password", "Try Again");
            }
           
        }
    }
}
