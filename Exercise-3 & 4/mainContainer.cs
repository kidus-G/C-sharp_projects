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
    public partial class mainContainer : Form
    {
        public static mainContainer instance2;
        public mainContainer()
        {
            
            InitializeComponent();
            instance2 = this;
            Form1 form = new Form1();
            form.MdiParent = this;
            form.Show();
        }

        private void addNewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) 
            {
                ActiveMdiChild.Close(); 
            }

            Form1 form = new Form1();
            form.MdiParent = this;
            form.Show();
        }

        private void displayBySearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            Form3 form = new Form3();
            form.MdiParent = this;
            form.Show();

        }

        private void displayAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            Form6 form = new Form6();
            form.MdiParent = this;
            form.Show();
            
        }

        private void deletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            Form5 form = new Form5();
            form.MdiParent = this;
            form.Show();
        }
    }
}
