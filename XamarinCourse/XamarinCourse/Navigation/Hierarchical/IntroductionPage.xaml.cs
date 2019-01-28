using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.Navigation.Hierarchical
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IntroductionPage : ContentPage
	{
        private async void Handle_Clicked(object sender, EventArgs args)
        {
            await Navigation.PopAsync();
        }

        public IntroductionPage ()
		{
			InitializeComponent ();
		}

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}