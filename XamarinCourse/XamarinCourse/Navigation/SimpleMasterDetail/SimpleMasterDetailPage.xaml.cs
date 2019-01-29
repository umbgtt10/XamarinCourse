using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCourse.Lists;
using XamarinCourse.Models;

namespace XamarinCourse.Navigation.SimpleMasterDetail
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SimpleMasterDetailPage : MasterDetailPage
    {
        private readonly ObservableCollection<Contact> _contacts;

		public SimpleMasterDetailPage()
		{
			InitializeComponent ();

            _contacts = new ObservableCollection<Contact>()
            {
                new Contact() {Name = "Umberto", Slogan = "I am here", ImageUrl = ImageSource.FromUri(new Uri("http://lorempixel.com/100/100/people/1"))},
                new Contact() {Name = "John", Slogan = "I am there", ImageUrl = ImageSource.FromUri(new Uri("http://lorempixel.com/100/100/people/2"))},
            };

            ContactsListView.ItemsSource = _contacts;
        }

        private void ContactsListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            Detail = new NavigationPage(new ContactDetailPage(contact));
            IsPresented = false; // :( bad naming for 'IsMasterPresented'
        }
    }
}