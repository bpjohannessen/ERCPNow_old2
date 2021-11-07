using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ERCPNow.ViewModels;

namespace ERCPNow.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SavedDetailView : ContentPage
    {
        private SavedDetailViewModel _vm;
        public SavedDetailView(SavedDetailViewModel vm)
        {
            InitializeComponent();
            
            BindingContext = vm;
            _vm = vm;
        }
    }
}