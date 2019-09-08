using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using Gratitude.Models;
using Xamarin.Forms.Xaml;

namespace Gratitude
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetGratitudesAsync();
        }

        async void OnAddClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntryPage
            {
                BindingContext = new Gratitude.Models.Gratitude()
            });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new EntryPage
                {
                    BindingContext = e.SelectedItem as Gratitude.Models.Gratitude
                });
            }
        }
    }
}