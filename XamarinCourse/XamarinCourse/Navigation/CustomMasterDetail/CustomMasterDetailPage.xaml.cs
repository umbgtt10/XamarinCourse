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

namespace XamarinCourse.Navigation.CustomMasterDetail
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomMasterDetailPage : ContentPage
    {
        private readonly ObservableCollection<Contact> _contacts;

		public CustomMasterDetailPage()
		{
			InitializeComponent ();

            _contacts = new ObservableCollection<Contact>()
            {
                new Contact() {Name = "Umberto", Slogan = "I am here", ImageUrl = ImageSource.FromUri(new Uri("http://lorempixel.com/100/100/people/1"))},
                new Contact() {Name = "John", Slogan = "I am there", ImageUrl = ImageSource.FromUri(new Uri("http://lorempixel.com/100/100/people/2"))},
            };

            ContactsListView.ItemsSource = _contacts;
        }

        private async void ContactsListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var contact = e.SelectedItem as Contact;
                await Navigation.PushAsync(new ContactDetailPage(contact));
                RemoveSelection();
            }
        }

        private void RemoveSelection()
        {
            ContactsListView.SelectedItem = null;
        }
    }
}