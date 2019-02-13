using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.Forms.Exercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactBookExercise : ContentPage
    {
        public ContactBookExerciseViewModel _vm
        {
            get { return BindingContext as ContactBookExerciseViewModel; }
        }

        public ContactBookExercise()
        {
            InitializeComponent();

            BindingContext = new ContactBookExerciseViewModel(Generate());
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var contactDetailPage = new ContactDetailPage();
            contactDetailPage.ContactAdded += (s, contact) => _vm.Contacts.Add(contact);

            Navigation.PushAsync(contactDetailPage);
        }

        private IList<Contact> Generate()
        {
            var items = new List<Contact>()
            {
                new Contact() {Name = "Jack", Surname = "Smith"},
                new Contact() {Name = "Bob", Surname = "Johnson"}
            };

            return items;
        }

        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            var element = (sender as MenuItem).CommandParameter as Contact;

            _vm.Contacts.Remove(element);
        }
    }
}