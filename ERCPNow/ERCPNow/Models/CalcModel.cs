using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ERCPNow.Models
{
    public class CalcModel : INotifyPropertyChanged
    {
        
        
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}