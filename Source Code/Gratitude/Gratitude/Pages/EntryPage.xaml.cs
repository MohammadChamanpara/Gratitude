using Plugin.LocalNotifications;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gratitude
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryPage : ContentPage
    {
        public EntryPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var item = (Gratitude.Models.Gratitude)BindingContext;
            item.Date = DateTime.UtcNow;
            await App.Database.SaveGratitudesAsync(item);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var item = (Gratitude.Models.Gratitude)BindingContext;
            await App.Database.DeleteGratitudesAsync(item);
            await Navigation.PopAsync();
        }
    }
}