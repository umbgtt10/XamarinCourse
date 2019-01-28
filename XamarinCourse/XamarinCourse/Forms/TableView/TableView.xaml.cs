using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.Forms.TableView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TableView : ContentPage
	{
		public TableView ()
		{
			InitializeComponent ();
		}

        private void Cell_OnTapped(object sender, EventArgs e)
        {
            // Main to be wrapped in navigation
            var contactMethodsPage = new ContactMethodsPage();
            contactMethodsPage.ContactMethods.ItemSelected += (source, args) =>
                {
                    ContactMethod.Text = args.SelectedItem.ToString();
                    Navigation.PopAsync();
                };
            Navigation.PushAsync(contactMethodsPage);
        }
    }
}