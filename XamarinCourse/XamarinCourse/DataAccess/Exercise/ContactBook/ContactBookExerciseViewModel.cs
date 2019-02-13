using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace XamarinCourse.DataAccess.Exercise.ContactBook
{
    public class ContactBookExerciseViewModel : BaseViewModel
    {
        private ObservableCollection<Contact> _contacts;
        public ObservableCollection<Contact> Contacts
        {
            get { return _contacts;}

            set { _contacts = value; OnPropertyChanged();  }
        }

        public ContactBookExerciseViewModel(IList<Contact> contacts)
        {
            Contacts = new ObservableCollection<Contact>(contacts);
        }
    }
}