using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.Lists.Exercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AirBnbView : ContentPage
    {
        public AirBnbViewModel _vm
        {
            get { return BindingContext as AirBnbViewModel; }
        }

        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var text = e.NewTextValue;

            var newList = _vm.Entries.Where(element => element.Title.StartsWith(text));

            UpdateList(newList);
        }

        public AirBnbView()
        {
            InitializeComponent();

            UpdateList(Generate());
        }

        private void UpdateList(IEnumerable<Location> list)
        {
            BindingContext = new ObservableCollection<Location>(list);
        }

        private IEnumerable<Location> Generate()
        {
            var items = new List<Location>()
            {
                new Location()
                {
                    City = "Baden",
                    Country = "CH",
                    State = "Aargau",
                    End = new DateTime(2018, 10, 10),
                    Start = new DateTime(2018, 8, 10)
                },
                new Location()
                {
                    City = "Zürich",
                    Country = "CH",
                    State = "Zürich",
                    End = new DateTime(2019, 10, 10),
                    Start = new DateTime(2019, 8, 10)
                },
            };

            return items;
        }

        private void PullToRefreshList_OnRefreshing(object sender, EventArgs e)
        {
            UpdateList(Generate());
        }

        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            var element = (sender as MenuItem).CommandParameter as Location;

            _vm.Entries.Remove(element);
        }
    }
}