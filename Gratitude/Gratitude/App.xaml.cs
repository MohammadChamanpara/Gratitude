using Gratitude.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gratitude
{
    public partial class App : Application
    {
        static GratitudeDatabase database;

        public static GratitudeDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new GratitudeDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Gratitudes.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ListPage());
        }
    }
}
