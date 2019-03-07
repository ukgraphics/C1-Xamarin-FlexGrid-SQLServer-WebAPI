using C1XfFlexGrid.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace C1XfFlexGrid
{
    public partial class App : Application
    {
        public static CustomersManager CustomersManager { get; private set; }

        public App()
        {
            InitializeComponent();

            C1.Xamarin.Forms.Core.LicenseManager.Key = License.Key;

            CustomersManager = new CustomersManager(new RestService());

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
