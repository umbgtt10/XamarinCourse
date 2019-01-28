using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.Navigation.Modal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ModalNavigation : ContentPage
	{
        private async void Handle_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new IntroductionPage());
        }

        public ModalNavigation ()
		{
			InitializeComponent ();
		}
	}
}