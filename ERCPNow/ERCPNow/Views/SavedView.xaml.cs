using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERCPNow.Models;
using ERCPNow.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ERCPNow.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SavedView : ContentPage
    {
        public SavedView()
        {
            InitializeComponent();
            BindingContext = new SavedViewModel();
        }
        
        protected override async void OnAppearing()
        {
            SavedList.ItemsSource = await App.Database.GetCalcsAsync();
        }

        private void SavedList_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            //throw new NotImplementedException();
            SavedList.SelectedItem = null;
            var dto = (CalculatorViewModel)e.Item;
            var detailview = new SavedDetailView(new SavedDetailViewModel(dto, Navigation));
            Navigation.PushAsync(detailview);
        }
    }
}