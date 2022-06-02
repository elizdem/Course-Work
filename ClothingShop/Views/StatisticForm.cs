using ClothingShop.Entities;
using ClothingShop.Services;
using LiveCharts;
using LiveCharts.Wpf;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingShop.Views
{
    public partial class StatisticForm : MaterialForm
    {
        private readonly ISoldProductService _soldProducts = new SoldProductStatisticService();

        //List<SoldProductService> _soldProducts = new List<SoldProductService>();
        public StatisticForm()
        {
            InitializeComponent();
            _soldProducts.GetAllStatisticList();
        }

        private void FillSoldProductList()
        {
            SoldProductListView.Items.Clear();

            var soldProducts = _soldProducts.GetAllStatisticList();

            foreach (var soldProduct in soldProducts)
            {
                var lvi = new ListViewItem(new[]
                {
                    $"{soldProduct.Sum}",
                    $"{soldProduct.Date}"
                });

                SoldProductListView.Items.Add(lvi);
            }
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow700, Primary.Purple900, Primary.Purple900, Accent.Yellow700, TextShade.WHITE);
            FillSoldProductList();

            //soldProductsStatisticBindingSource.DataSource = new List<SoldProductsStatistic>();

            //Chart.AxisY.Add(new LiveCharts.Wpf.Axis
            //{
            //    Title = "Cost",
            //    LabelFormatter = sum => sum.ToString("C")
            //});

            //Chart.AxisX.Add(new LiveCharts.Wpf.Axis
            //{
            //    Title = "Date",
            //    //LabelFormatter = date => date.ToString("D")
            //    Labels = new[] { "Янв", "Фев", "Март", "Апр", "Май", "Июнь", "Июль", "Авг", "Сент", "Окт", "Ноябрь", "Дек" }
            //});

            //Chart.LegendLocation = LiveCharts.LegendLocation.Right;
        }

        //private void ChartButton_Click(object sender, EventArgs e)
        //{
        //    Chart.Series.Clear();
        //    SeriesCollection series = new SeriesCollection();
        //    var Date = (from o in soldProductsStatisticBindingSource.DataSource as List<SoldProductsStatistic>
        //                select new { Date = o.Date }).Distinct();
        //    foreach (var date in Date)
        //    {
        //        List<int> sums = new List<int>();
        //        for (int m = 1; m < 12; m++)
        //        {
        //            int summa = 0;
        //            var data = from o in soldProductsStatisticBindingSource.DataSource as List<SoldProductsStatistic>
        //                       where o.Date.Equals(date.Date) && o.Date.Equals(m)
        //                       orderby o.Date ascending
        //                       select new { o.Sum, o.Date };
        //            if (data.SingleOrDefault() != null)
        //                summa = data.SingleOrDefault().Sum;
        //            sums.Add(summa);
        //        }
        //        series.Add(new LineSeries() { Title = date.Date.ToString(), Values = new ChartValues<int>(sums) });
        //    }
        //    Chart.Series = series;
        //}

        private void searchByDate(string searchTerm)
        {
            SoldProductListView.Items.Clear();
            var sold = _soldProducts.GetAllStatisticList();
            foreach(var soldproduct in sold)
            {
                if (soldproduct.Date.ToString().Contains(searchTerm))
                {
                    SoldProductListView.Items.Add(new ListViewItem(new[]
                    {
                        $"{soldproduct.Sum}",
                        $"{soldproduct.Date}"
                    }));
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchByDate(SearchTextBox.Text);
        }

        public int CalculateSum()
        {
            int sum = 0;
            for (int i = 0; i < SoldProductListView.Items.Count; i++)
            {
                sum += int.Parse(SoldProductListView.Items[i].SubItems[0].Text);
            }
            return sum;
        }

        private void StatButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Выручка: {CalculateSum()}");
        }
    }
}