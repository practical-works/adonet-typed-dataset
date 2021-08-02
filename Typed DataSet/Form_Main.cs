using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GroceryManager
{
    public partial class Form_Main : Form
    {
        private Form_Products _form_products = null;

        public Form_Main()
        {
            InitializeComponent();
            button_products_Click(null, null);
        }

        private void button_products_Click(object sender, EventArgs e)
        {
            if (_form_products == null || _form_products.IsDisposed)
            {
                _form_products = new Form_Products();
                _form_products.MdiParent = this;
                _form_products.Load += (s, args) =>
                {
                    Text = string.Format("Products - {0}", Application.ProductName); 
                };
                _form_products.FormClosed += (s, args) =>
                {
                    Text = Application.ProductName;
                };
            }
            _form_products.Show();
        }
    }
}
