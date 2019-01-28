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
	public partial class IntroductionPage : ContentPage
	{
        private async void Handle_Clicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }

        public IntroductionPage ()
		{
			InitializeComponent ();
		}
	}
}