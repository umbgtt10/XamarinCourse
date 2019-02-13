using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace XamarinCourse.Lists.Exercise
{
    public class AirBnbViewModel : BaseViewModel
    {
        private ObservableCollection<Location> _entries;
        public ObservableCollection<Location> Entries
        {
            get { return _entries; }

            set { _entries = value; OnPropertyChanged(); }
        }

        public AirBnbViewModel(IList<Location> contacts)
        {
            Entries = new ObservableCollection<Location>(contacts);
        }
    }
}