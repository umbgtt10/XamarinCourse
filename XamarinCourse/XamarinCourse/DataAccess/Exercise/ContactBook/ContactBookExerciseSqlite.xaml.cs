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

namespace XamarinCourse.DataAccess.Exercise.ContactBook
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactBookExerciseSqlite : ContentPage
    {
        public ContactBookExerciseViewModel _vm
        {
            get { return BindingContext as ContactBookExerciseViewModel; }
        }

        private readonly SQLiteAsyncConnection _connection;

        public ContactBookExerciseSqlite()
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
            contactDetailPage.ContactAdded += OnContactDetailPageOnContactAdded;

            Navigation.PushAsync(contactDetailPage);
        }

        private async void OnContactDetailPageOnContactAdded(object s, Contact contact)
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