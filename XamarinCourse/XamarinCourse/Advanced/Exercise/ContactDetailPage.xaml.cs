using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.Advanced.Exercise
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactDetailPage : ContentPage
	{
        public ContactDetailPage()
		{
			InitializeComponent ();
		}

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var newContact = new Contact()
            {
                Name = FirstName.Text, Surname = LastName.Text
            };

            MessagingCenter.Send(this, "OnAddingNewContact", newContact);

            Navigation.PopAsync();
        }
    }
}