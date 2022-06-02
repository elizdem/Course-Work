using ClothingShop.Services;
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
    public partial class SellerForm : MaterialForm
    {
        private readonly IProductService _productService = new ProductService();

        public SellerForm()
        {
            InitializeComponent();
            FillProductList();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow700, Primary.Purple900, Primary.Purple900, Accent.Yellow700, TextShade.WHITE);

            FillProductList();
        }

        private void FillProductList()
        {
            ProductListView.Items.Clear();

            var products = _productService.GetProductsFromJSON();

            foreach (var product in products)
            {
                var lvi = new ListViewItem(new[]
                {
                   $"{product.Name}",
                   $"{product.Type}",
                   $"{product.Article}",
                   $"{product.Cost}",
                   $"{product.Brand}",
                   $"{product.Size}"
               });

                ProductListView.Items.Add(lvi);
            }
        }

        private void search(string searchTerm)
        {
            ProductListView.Items.Clear();
            var products = _productService.GetAllProducts();
            foreach (var product in products)
            {
                if(product.Name.ToLower().Contains(searchTerm.ToLower()) || product.Brand.ToLower().Contains(searchTerm.ToLower()) || product.Cost.ToString().Contains(searchTerm) || product.Article.ToString().Contains(searchTerm))
                {
                    ProductListView.Items.Add(new ListViewItem(new[]
                    {
                       $"{product.Name}",
                       $"{product.Type}",
                       $"{product.Article}",
                       $"{product.Cost}",
                       $"{product.Brand}",
                       $"{product.Size}"
                   }));
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm autorizationForm = new AuthorizationForm();
            autorizationForm.ShowDialog();
            Close();
        }

        private void MakeOrderButton_Click(object sender, EventArgs e)
        {
            MakeOrderForm makeOrderForm = new MakeOrderForm();
            makeOrderForm.ShowDialog();
            Close();
        }

        private void searchListBox_TextChanged(object sender, EventArgs e)
        {
            search(searchListBox.Text);
        }
    }
}
