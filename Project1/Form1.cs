using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Degiskenler
            string productsText = "Urunler";
            var addToCartButtonText = "Sepete Ekle";
            var cartText = "Sepetiniz";
            var confirmCart = "Sepeti Onayla";
            var removeFromCart = "Sepetten Cikar";

            // Isimlendirmeler
            lblProducts.Text = productsText;
            btnAddToCart.Text = addToCartButtonText;
            lblCart.Text = cartText;
            btnConfirmCart.Text = confirmCart;
            btnRemoveFromCart.Text = removeFromCart;
            

            /*
            lbxProducts.Items.Add("Laptop");
            lbxProducts.Items.Add("Masaustu PC");
            lbxProducts.Items.Add("Klavye");
            lbxProducts.Items.Add("Fare");
            lbxProducts.Items.Add("Kulaklik");
            */

            string[] products = new string[] {"Laptop","Masaustu PC","Klavye","Fare","Kulaklik" };
            /*
            for (int i = 0; i<products.Length; i++)
            {
                lbxProducts.Items.Add(products[i]);
            }
            */

            foreach (var item in products)
            {
                lbxProducts.Items.Add(item);
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
                btnConfirmCart.Enabled = false;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                btnConfirmCart.Enabled = true;
                btnRemoveFromCart.Enabled = true;
            }
            else
            {
                MessageBox.Show("Oncelikle bir urun secmelisiniz.");
            }
        }

        private void btnConfirmCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.Items.Count != 0)
            {
                btnConfirmCart.Enabled = true;
                MessageBox.Show("Sepetiniz onaylandi.");
                lbxCart.Items.Clear();
                btnRemoveFromCart.Enabled = false;
                btnConfirmCart.Enabled = false;
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }
            else
            {
                btnRemoveFromCart.Enabled = false;
                btnConfirmCart.Enabled = false;
            }
        }
    }
}
