using SQLite;
using Xamarin.Forms;

namespace XamarinCourse.Mvvm.Exercise
{
    public class ContactDetailPageViewModel : BaseViewModel
    {
        private Contact _contact;

        public Contact NewContact
        {
            get { return _contact; }
            set
            {
                _contact = value;
                OnPropertyChanged();
            }
        }

        public Command SaveCommand { get; private set; }
        private readonly SQLiteAsyncConnection _connection;
        private readonly INavigation _navigation;

        public ContactDetailPageViewModel(SQLiteAsyncConnection connection, INavigation navigation)
        {
            _connection = connection;
            _navigation = navigation;
            SaveCommand = new Command(Save);
            _contact = new Contact();
        }

        private async void Save()
        {
            await _connection.InsertAsync(NewContact);
            await _navigation.PopAsync();
        }
    }
}