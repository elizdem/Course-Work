using ClothingShop.Entities;
using MaterialSkin;
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
    partial class AddProviderForm : MaterialForm
    {
        public Provider Provider { get; set; }

        public AddProviderForm()
        {
            InitializeComponent();
        }

        private void AddProviderButton_Click(object sender, EventArgs e)
        {
            var randomizer = new Random();
            Provider = new Provider
            {
                Id = randomizer.Next(),
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                CompanyName = CompanyNameTextBox.Text,
                TelNumber = int.Parse(TelNumberTextBox.Text),
                Email = EmailTextBox.Text

            };
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void CancelAddButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AddProviderForm_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow700, Primary.Purple900, Primary.Purple900, Accent.Yellow700, TextShade.WHITE);
        }
    }
}