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
    public partial class ProviderForm : MaterialForm
    {
        private readonly IProviderService _providerService = new ProviderService();

        public ProviderForm()
        {
            InitializeComponent();
        }

        private void ProviderForm_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow700, Primary.Purple900, Primary.Purple900, Accent.Yellow700, TextShade.WHITE);

            FillProvidersList();

        }

        private void FillProvidersList()
        {
            ProviderListView.Items.Clear();
            var providers = _providerService.GetProviders();

            foreach (var provider in providers)
            {
                var lvi = new ListViewItem(new[]
                {
                       $"{provider.LastName}",
                       $"{provider.FirstName}",
                       $"{provider.CompanyName}",
                       $"{provider.TelNumber}",
                       $"{provider.Email}",
                   
                });

                ProviderListView.Items.Add(lvi);
            }
            
        }

        private void AddProviderButton_Click(object sender, EventArgs e)
        {
            var AddProviderForm = new AddProviderForm();
            
            if (AddProviderForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var newProvider = AddProviderForm.Provider;
            _providerService.AddProviders(newProvider);

            FillProvidersList();
        }

        private void RemoveProviderButton_Click(object sender, EventArgs e)
        {
            if (ProviderListView.SelectedIndices.Count == 0)
            {
                return;
            }
            var indx = ProviderListView.SelectedIndices[0];

            var providerId = _providerService.GetProviders()
                                             .ElementAt(indx)
                                             .Id;
            _providerService.RemoveProvider(providerId);
            FillProvidersList();
        }
    }
}
