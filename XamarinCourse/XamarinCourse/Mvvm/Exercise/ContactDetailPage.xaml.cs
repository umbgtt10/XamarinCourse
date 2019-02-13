using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.Mvvm.Exercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactDetailPage : ContentPage
	{
        public ContactDetailPage(SQLiteAsyncConnection connection)
		{
			InitializeComponent();
            
            BindingContext = new ContactDetailPageViewModel(connection, Navigation);
        }
    }
}