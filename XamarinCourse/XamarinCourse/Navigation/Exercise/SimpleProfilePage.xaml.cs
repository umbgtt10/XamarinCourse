using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCourse.Navigation.Exercise.Services;

namespace XamarinCourse.Navigation.Exercise
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SimpleProfilePage : ContentPage
    {
        private UserProfileService _userProfileService = new XamarinUserProfileService();

        public SimpleProfilePage() : this(0)
        {
            InitializeComponent();
        }

        public SimpleProfilePage (int id)
		{
			InitializeComponent ();

            BindingContext = _userProfileService.Get(id);
        }
	}
}