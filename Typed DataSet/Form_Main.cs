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
        public Form_Main()
        {
            InitializeComponent();


            Form_Products form_products = new Form_Products();
            form_products.MdiParent = this;
            form_products.Show();
        }
    }
}
