using ClothingShop.Data;
using ClothingShop.Services;
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
using MaterialSkin;



namespace ClothingShop.Views
{
    public partial class AdminProductForm : MaterialForm
    {
        private readonly IProductService _productService = new ProductService();

        public AdminProductForm()
        {
            InitializeComponent();
        }

        private void AdminProductForm_Load(object sender, EventArgs e)
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

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            var AddProductForm = new AddProductForm(); // - связала с формой 

            if (AddProductForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var newProduct = AddProductForm.Product;

            _productService.AddProduct(newProduct);

            FillProductList();
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if(ProductListView.SelectedIndices.Count == 0)
            {
                return;
            }

            var indx = ProductListView.SelectedIndices[0];

            var productId = _productService.GetProductsFromJSON()
                                           .ElementAt(indx)
                                           .Id;
            _productService.RemoveProduct(productId);

            FillProductList();
        }
    }
}
