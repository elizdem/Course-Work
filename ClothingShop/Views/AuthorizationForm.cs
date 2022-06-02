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
    public partial class AuthorizationForm : MaterialForm
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AutorizationForm_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow700, Primary.Purple900, Primary.Purple900, Accent.Yellow700, TextShade.WHITE);
        }

        private void AutorizeButton_Click(object sender, EventArgs e)
        {

            if (userComboBox.Text == "Администратор" && loginTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                Hide();
                AdminForm form2 = new AdminForm();
                form2.ShowDialog();
                Close();
            }

            if (userComboBox.Text == "Продавец-консультант" && loginTextBox.Text == "seller" && passwordTextBox.Text == "seller")
            {
                Hide();
                SellerForm sellerForm = new SellerForm();
                sellerForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
