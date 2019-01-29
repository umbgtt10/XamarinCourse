using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.Advanced.ResourceDictionary
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResourceDictionaryPage : ContentPage
	{
        private void Handle_Clicked(object sender, EventArgs args)
        {
            Resources["buttonBackgroundColor"] = Color.Pink;
        }

		public ResourceDictionaryPage ()
		{
			InitializeComponent ();
        }
	}
}