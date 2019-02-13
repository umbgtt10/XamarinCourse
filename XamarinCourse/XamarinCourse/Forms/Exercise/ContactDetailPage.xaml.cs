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
	public partial class ContactDetailPage : ContentPage
	{
        public event EventHandler<Contact> ContactAdded;

        public ContactDetailPage()
		{
			InitializeComponent ();
		}

        private void Button_OnClicked(object sender, EventArgs e)
        {
            if (ContactAdded != null)
            {
                var newContact = new Contact()
                {
                    Name = FirstName.Text, Surname = LastName.Text
                };

                ContactAdded.Invoke(this, newContact);
            }

            Navigation.PopAsync();
        }
    }
}