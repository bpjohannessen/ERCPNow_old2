using System.ComponentModel;
using System.Runtime.CompilerServices;
using SQLite;

namespace ERCPNow.Models
{
    [Table("tbl_calcs")]
    public class CalcModel : INotifyPropertyChanged
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Initials { get; set; }
        [MaxLength(255)]
        public int Age { get; set; }
        [MaxLength(255)]
        public int Alat { get; set; }
        [MaxLength(255)]
        public int Ggt { get; set; }
        [MaxLength(255)]
        public int Bilirubin { get; set; }
        
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}