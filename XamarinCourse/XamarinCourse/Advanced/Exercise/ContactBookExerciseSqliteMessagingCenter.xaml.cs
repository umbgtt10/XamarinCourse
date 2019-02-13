using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCourse.DataAccess.Sqlite;

namespace XamarinCourse.Advanced.Exercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactBookExerciseSqliteMessagingCenter : ContentPage
    {
        public ContactBookExerciseViewModel _vm
        {
            get { return BindingContext as ContactBookExerciseViewModel; }
        }

        private readonly SQLiteAsyncConnection _connection;

        public ContactBookExerciseSqliteMessagingCenter()
        {
            InitializeComponent();

            BindingContext = new ContactBookExerciseViewModel(new List<Contact>());

            _connection = DependencyService.Get<SqlLiteDb>().GetConnection();
        }

        protected override async void OnAppearing()
        {
            await _connection.CreateTableAsync<Contact>();

            var contacts = await _connection.Table<Contact>().ToListAsync();
            _vm.Contacts = new ObservableCollection<Contact>(contacts);

            base.OnAppearing();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var contactDetailPage = new ContactDetailPage();

            MessagingCenter.Subscribe<ContactDetailPage,Contact>(
                this,
                "OnAddingNewContact", 
                OnContactDetailPageOnContactAdded);

            Navigation.PushAsync(contactDetailPage);
        }

        private async void OnContactDetailPageOnContactAdded(ContactDetailPage s, Contact contact)
        {
            await _connection.InsertAsync(contact);
            _vm.Contacts.Add(contact);
        }

        private async void MenuItem_OnClicked(object sender, EventArgs e)
        {
            var element = (sender as MenuItem).CommandParameter as Contact;

            await _connection.DeleteAsync(element);

            _vm.Contacts.Remove(element);
        }
    }
}