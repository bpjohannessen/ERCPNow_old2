namespace ERCPNow.ViewModels
{
    public class CalculatorViewModel : BaseViewModel
    {
        #region Variables for calculator

        private string _initials;
        private int _age;
        private int _alat;
        private int _ggt;
        private int _bilirubin;

        public string Initials
        {
            get => _initials;
            set
            {
                _initials = value;
                OnPropertyChanged(Initials);
            }
        }

        #endregion


        public CalculatorViewModel()
        {
            Title = "Calculator";
        }
    }
}