using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinCourse.DataAccess.Exercise.NetflixRoulette
{
    public class NetflixRouletteViewModel : BaseViewModel
    {
        private ObservableCollection<Movie> _movies;

        public ObservableCollection<Movie> Movies
        {
            get { return _movies;}
            set { _movies = value; OnPropertyChanged(); }
        }

        public ICommand SearchCommand { get; private set; }

        private readonly DataAccess _dataAccess;

        public NetflixRouletteViewModel(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
            Movies = new ObservableCollection<Movie>();
            SearchCommand = new Command(Search);
        }

        private async void Search(object autor)
        {
            Movies = new ObservableCollection<Movie>(await _dataAccess.GetByActorAsync((string)autor));
        }
    }
}