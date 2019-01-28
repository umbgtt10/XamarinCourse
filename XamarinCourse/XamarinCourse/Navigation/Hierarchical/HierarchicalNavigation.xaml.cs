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
	public partial class HierarchicalNavigation : ContentPage
	{
        private async void Handle_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new IntroductionPage());
        }

        public HierarchicalNavigation ()
		{
			InitializeComponent ();
		}
	}
}