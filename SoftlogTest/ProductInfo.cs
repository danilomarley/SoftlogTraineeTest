using SoftlogTest.Entity;
using SoftlogTest.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftlogTest
{
    public partial class ProductInfo : Form
    {
        public ProductInfo(Product product)
        {
            InitializeComponent();
            if (product != null)
                BoundProductData(product);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProductController.AllProducts.Add(new Product(txtCode.Text, txtDescription.Text, double.Parse(txtPrice.Text), chkActive.Checked));
            this.Close();
        }

        private void BoundProductData(Product product)
        {
            txtCode.Text = product.Code;
            txtDescription.Text = product.Description;
            txtPrice.Text = product.Price.ToString();
            chkActive.Checked = product.Active;
            btnSave.Visible = false;
            txtCode.Enabled = false;
            txtDescription.Enabled = false;
            txtPrice.Enabled = false;
            chkActive.Enabled = false;
        }
    }
}
