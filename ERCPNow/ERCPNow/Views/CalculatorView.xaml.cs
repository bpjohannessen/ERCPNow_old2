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
    public partial class CalculatorView : ContentPage
    {
        public CalculatorView()
        {
            InitializeComponent();
            BindingContext = new CalculatorViewModel();
        }

        async void SavedClicked(object sender, EventArgs e)
        {
            await App.Database.SaveNoteAsync(new CalcModel
            {
                Initials = InputInitials.Text,
                Age = Int32.Parse(InputAge.Text)
            });
        }

    }
}