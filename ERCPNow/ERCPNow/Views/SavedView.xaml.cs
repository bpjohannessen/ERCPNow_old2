using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}