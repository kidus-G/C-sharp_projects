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
    public partial class productcard : UserControl
    {

        #region properties
        private string _product;
        private string _inventorynumber;
        private string _price;
        public string Product
        {
            get { return _product; }
            set { _product = value; label1.Text = value; }
        }

        public string Inventorynumber
        {
            get { return _inventorynumber; }
            set { _inventorynumber = value; label2.Text = value; }
        }
        public string Price
        {
            get { return _price; }
            set { _price = value; label3.Text = value; }
        }

        #endregion


        public productcard()
        {
            InitializeComponent();
        }

    }
}
