using C1XfFlexGrid.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace C1XfFlexGrid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            PopulateListViewAsync();
        }

        private async void PopulateListViewAsync()
        {
            var items = await App.CustomersManager.GetCustomersAsync();
            flexgrid.ItemsSource = items;
        }

    }
}
