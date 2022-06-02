using ClothingShop.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothingShop.Data;
using System.IO;
using ClothingShop.Services;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ClothingShop.Views
{
    public partial class MakeOrderForm : MaterialForm
    {
        private readonly ISoldProductService _soldProductService = new SoldProductStatisticService();
        private readonly IProductService _productService = new ProductService();
        

        public MakeOrderForm()
        {
            InitializeComponent();
            _soldProductService.GetAllStatisticList();
        }

        private void AddToListBoxButton_Click(object sender, EventArgs e)
        {
            var artcl = int.Parse(ArticleTextBox.Text);
            foreach (var product in _productService.GetProductsByArticle(artcl))
            {
                 
                var lvi = new ListViewItem(new[]
                {
                   $"{product.Article}",
                   $"{product.Name}",
                   $"{product.Cost}",

               });
                MakeOrderListView.Items.Add(lvi);
                ArticleTextBox.Clear();
            }
        }

        public void SaveStatisticInformation()
        {
            SoldProductsStatistic soldStatistic = new SoldProductsStatistic();
            soldStatistic.Sum = this.CalculateSum();
            soldStatistic.Date = DateTime.Now;
            _soldProductService.AddSoldProductStatistic(soldStatistic);
        }
        public int CalculateSum()
        {
            int sum = 0;
            for (int i = 0; i < MakeOrderListView.Items.Count; i++)
            {
                sum += int.Parse(MakeOrderListView.Items[i].SubItems[2].Text);
            }
            return sum;
        }

        void ClearListView()
        {
            for(int i = MakeOrderListView.Items.Count-1; i >= 0; i--)
            {
                MakeOrderListView.Items[i].Remove();
            };
            MakeOrderListView.Update();
        }
        private void ResultButton_Click(object sender, EventArgs e)
        {
            SaveStatisticInformation();
            MessageBox.Show($"Сумма: {CalculateSum()}\nВремя: {DateTime.Now.ToShortTimeString()}", $"Дата: {DateTime.Now.ToShortDateString()}") ;
            ClearListView();

        }

        private void MakeOrderForm_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow700, Primary.Purple900, Primary.Purple900, Accent.Yellow700, TextShade.WHITE);
        }



        private void DeleteProductButton_Click_1(object sender, EventArgs e)
        {
            if (MakeOrderListView.SelectedIndices.Count == 0)
            {
                return;
            }

            var indx = MakeOrderListView.SelectedIndices[0];
        }
    }
}