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
    public partial class AdminForm : MaterialForm
    {
        
        public AdminForm()
        {
            InitializeComponent();
        }

        private void soldProductButton_Click(object sender, EventArgs e)
        {
            StatisticForm statForm = new StatisticForm();
            statForm.ShowDialog();
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            AdminProductForm productForm = new AdminProductForm();
            productForm.ShowDialog();
            
        }

        private void ProviderButton_Click(object sender, EventArgs e)
        {
            ProviderForm providerForm = new ProviderForm();
            providerForm.ShowDialog();
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm autorizationForm = new AuthorizationForm();
            autorizationForm.ShowDialog();
            Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow700, Primary.Purple900, Primary.Purple900, Accent.Yellow700, TextShade.WHITE);
        }
    }
}
