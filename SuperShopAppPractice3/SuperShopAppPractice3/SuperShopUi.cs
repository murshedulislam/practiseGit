using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopAppPractice3
{
    public partial class SuperShopUi : Form
    {
        Shop shop = new Shop();
        Product product = new Product();
        public SuperShopUi()
        {
            InitializeComponent();
        }

        private void ShopSaveButton_Click(object sender, EventArgs e)
        {
            shop.Name = nameTextBox.Text;
            shop.Address = addressTextBox.Text;


        }

        private void ProductSaveButton_Click(object sender, EventArgs e)
        {
            
            product.Id =Convert.ToInt32(itemTextBox.Text);
            product.Quantity = Convert.ToInt32(quantityTextBox.Text);

            shop.AddProduct(product);
        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(shop.ShowDetails());
        }
    }
}
