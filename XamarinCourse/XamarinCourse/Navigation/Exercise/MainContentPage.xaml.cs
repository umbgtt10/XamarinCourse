using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCourse.Navigation.Exercise.Model;
using XamarinCourse.Navigation.Exercise.Services;

namespace XamarinCourse.Navigation.Exercise
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainContentPage : ContentPage
	{
        private readonly ActivityService _activityService;

        public MainContentPage ()
        {
            _activityService = new XamarinActivityService();
            InitializeComponent ();

            ContactsListView.ItemsSource = _activityService.GetAll();
        }

        private void ContactsListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var itemNumber = ((Activity) e.SelectedItem).Id;
            var page = new SimpleProfilePage(itemNumber);

            Navigation.PushAsync(page);
            ContactsListView.SelectedItem = null;
        }
    }
}