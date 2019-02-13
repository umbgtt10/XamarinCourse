using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SQLite;

namespace XamarinCourse.Mvvm.Exercise
{
    public class Contact : INotifyPropertyChanged
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string _name;
        public string Name
        {
            get { return _name;}
            set { _name = value; OnPropertyChanged(); }
        }

        public string _surname;
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; OnPropertyChanged(); }
        }
        public string _phone;
        public string Phone        
        {
            get { return _phone; }
            set { _phone = value; OnPropertyChanged(); }
        }

        public string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(); }
        }

        public bool _isBlocked;
        public bool IsBlocked
        {
            get { return _isBlocked; }
            set { _isBlocked = value; OnPropertyChanged(); }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}