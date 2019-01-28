using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.Forms.Picker
{
    public class ContactMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Picker : ContentPage
    {
        private IList<ContactMethod> _contacts;

        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>()
            {
                new ContactMethod() {Id = 1, Name = "SMS"},
                new ContactMethod() {Id = 2, Name = "Email"},
            };
        }

        private void OnSelectedIndexChanged(object sender, EventArgs args)
        {
            var name = ContactPicker.Items[ContactPicker.SelectedIndex];
            var id = _contacts.Single(cn => cn.Name == name);
            DisplayAlert("Selection", name, "OK");
        }


        public Picker ()
        {
            _contacts = GetContactMethods();

            InitializeComponent ();
            foreach (var method in _contacts)
            {
                ContactPicker.Items.Add(method.Name);
            }
        }
	}
}