using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.DataAccess.Exercise.NetflixRoulette
{
    public class MovieDetailViewModel : BaseViewModel
    {
        private Movie _movie;

        public Movie Movie
        {
            get { return _movie; }
            set
            {
                _movie = value;
                OnPropertyChanged();
            }
        }

        public MovieDetailViewModel(Movie movie)
        {
            Movie = movie;
        }
    }

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MovieDetail : ContentPage
	{
		public MovieDetail (Movie movie)
		{
			InitializeComponent ();

            BindingContext = new MovieDetailViewModel(movie);
        }
	}
}