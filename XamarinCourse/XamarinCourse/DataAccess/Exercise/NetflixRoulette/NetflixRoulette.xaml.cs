using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.DataAccess.Exercise.NetflixRoulette
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NetflixRoulette : ContentPage
	{
        public NetflixRouletteViewModel _vm
        {
            get { return BindingContext as NetflixRouletteViewModel; }
        }

        public NetflixRoulette ()
		{
			InitializeComponent ();            
        }

        protected override void OnAppearing()
        {
            var dataAccess = new NetFlixDataAccess();

            BindingContext = new NetflixRouletteViewModel(dataAccess);

            base.OnAppearing();
        }

        private void GroupedList_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var detailPage = new MovieDetail((Movie)e.SelectedItem);

            Navigation.PushAsync(detailPage);
        }
    }
}