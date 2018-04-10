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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            PopularGridview();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductInfo productInfo = new ProductInfo(null);
            productInfo.ShowDialog();
            PopularGridview();
        }

        private void brtInfo_Click(object sender, EventArgs e)
        {
            if (gridViewProduct.SelectedRows.Count > 0)
            {
                Product product = (Product)gridViewProduct.SelectedRows[0].Tag;
                ProductInfo productInfo = new ProductInfo(product);
                productInfo.ShowDialog();
                PopularGridview();
            }
        }

        private void PopularGridview()
        {
            gridViewProduct.Rows.Clear();
            gridViewProduct.Columns.Clear();

            gridViewProduct.Columns.Add("Code", "Codigo");
            gridViewProduct.Columns.Add("Description", "Descrição");

            foreach (var product in ProductController.AllProducts)
            {
                int index = gridViewProduct.Rows.Add();
                gridViewProduct.Rows[index].Tag = product;
                gridViewProduct.Rows[index].Cells[0].Value = product.Code;
                gridViewProduct.Rows[index].Cells[1].Value = product.Description;
            }
        }

      
    }
}
