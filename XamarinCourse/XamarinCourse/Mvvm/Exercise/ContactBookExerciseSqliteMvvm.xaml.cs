using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.Mvvm.Exercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactBookExerciseSqliteMvvm : ContentPage
    {
        public ContactBookExerciseViewModel ViewModel
        {
            get { return BindingContext as ContactBookExerciseViewModel; }
        }

        public ContactBookExerciseSqliteMvvm()
        {
            InitializeComponent();

            var vm = new ContactBookExerciseViewModel(Navigation);

            BindingContext = vm;
        }

        protected async override void OnAppearing()
        {
            await ViewModel.Refresh();

            base.OnAppearing();
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            ViewModel.SelectedContact = (Contact) args.SelectedItem;
        }
    }
}