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

            getData(new GetData());
        }

        async void getData(GetData webDS)
        {
            List<Customer> Customers;

            try
            {
                Customers = await webDS.AsyncGetCustomers();
                flexgrid.ItemsSource = Customers;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "OK");
            }
        }
    }
}
