using ClothingShop.Entities;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingShop.Views
{
    partial class AddProductForm : MaterialForm
    {
        public Product Product { get; set; }

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var randomizer = new Random();

            Product = new Product
            {
                Id = randomizer.Next(),
                Name = nameText.Text,
                Type = typeText.Text,
                Article = int.Parse(articleText.Text),
                Cost = int.Parse(costText.Text),
                Brand = brandText.Text,
                Size = int.Parse(sizeText.Text)
            };

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void CancelAddButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
