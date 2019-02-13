using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using SQLite;
using Xamarin.Forms;
using XamarinCourse.DataAccess.Sqlite;

namespace XamarinCourse.Mvvm.Exercise
{
    public class ContactBookExerciseViewModel : BaseViewModel
    {
        private readonly SQLiteAsyncConnection _connection;

        private ObservableCollection<Contact> _contacts;
        public ObservableCollection<Contact> Contacts
        {
            get { return _contacts;}

            set { _contacts = value; OnPropertyChanged();  }
        }

        private Contact _selectedContact;

        public Contact SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                _selectedContact = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }

        private readonly INavigation _navigationService;

        public ContactBookExerciseViewModel(INavigation navigationService)
        {
            _navigationService = navigationService;
            AddCommand = new Command(OnAddContact);
            DeleteCommand = new Command(OnDeleteCommand);
            _connection = DependencyService.Get<SqlLiteDb>().GetConnection();
        }

        public async Task Refresh()
        {
            await _connection.CreateTableAsync<Contact>();

            var contacts = await _connection.Table<Contact>().ToListAsync();

            Contacts = new ObservableCollection<Contact>(contacts);
        }

        private async void OnAddContact()
        {
            var contactDetailPage = new ContactDetailPage(_connection);

            await _navigationService.PushAsync(contactDetailPage);

            await Refresh();
        }

        private async void OnDeleteCommand()
        {
            await _connection.DeleteAsync(SelectedContact);

            Contacts.Remove(SelectedContact);
        }
    }
}