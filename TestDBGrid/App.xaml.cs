using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DevExpress.XamarinForms.DataGrid;

namespace TestDBGrid
{
    public partial class App : Application
    {
        public App()
        {
            DevExpress.XamarinForms.DataGrid.Initializer.Init();
            InitializeComponent();
            DataGridView grid = new DataGridView();
            MainPage = new ContentPage //MainPage();
            {
                Content = grid,
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
