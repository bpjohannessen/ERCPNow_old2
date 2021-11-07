using Xamarin.Forms;

namespace ERCPNow.ViewModels
{
    public class SavedDetailViewModel : BaseViewModel
    {
        public readonly CalculatorViewModel calcDto;
        public SavedDetailViewModel(CalculatorViewModel calcDto, INavigation navigation)
        {
            Title = "Patient X";
        }
    }
}