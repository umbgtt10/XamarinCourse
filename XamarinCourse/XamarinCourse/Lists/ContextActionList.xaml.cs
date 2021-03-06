﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCourse.Models;

namespace XamarinCourse.Lists
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContextActionList : ContentPage
    {
        private ObservableCollection<Contact> _contacts;

        private void OnCallClicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }

        public ContextActionList ()
		{
            InitializeComponent ();

            _contacts = new ObservableCollection<Contact>()
            {
                new Contact() {Name = "Umberto", Slogan = "I am here", ImageUrl = ImageSource.FromUri(new Uri("http://lorempixel.com/100/100/people/1"))},
                new Contact()
                {
                    Name = "John", Slogan = "I am there",
                    ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.thewrap.com%2Fwp-content%2Fuploads%2F2015%2F11%2FDonald-Trump.jpg&imgrefurl=https%3A%2F%2Fwww.thewrap.com%2Fdonald-trump-slams-time-magazine-for-person-of-the-year-snub%2F&docid=ViuWKv8s1eDrzM&tbnid=-2SINjKvjAbM-M%3A&vet=10ahUKEwjf1Kzr5Y3gAhXNEVAKHXHxCNsQMwhYKBQwFA..i&w=618&h=412&bih=920&biw=1920&q=person%20image&ved=0ahUKEwjf1Kzr5Y3gAhXNEVAKHXHxCNsQMwhYKBQwFA&iact=mrc&uact=8"
                },
            };

            ContextList.ItemsSource = _contacts;
        }
	}
}