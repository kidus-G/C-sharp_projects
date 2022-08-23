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
    public partial class Form4 : Form
    {
        public static Form4 instance4;

        public Form4()
        {
            InitializeComponent();
            dataGridView1.DataSource = product.products;
        }
    }
}
