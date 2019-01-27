using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.Lists
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomListPage : ContentPage
	{
		public CustomListPage ()
		{
			InitializeComponent ();

            var list = new List<Person>()
            {
                new Person() {Name = "Umberto", Slogan = "I am here", ImageUrl = ImageSource.FromUri(new Uri("http://lorempixel.com/100/100/people/1"))},
                new Person()
                {
                    Name = "John", Slogan = "I am there",
                    ImageUrl = ImageSource.FromUri(new Uri("http://lorempixel.com/100/100/people/2"))
                },
            };

            CustomList.ItemsSource = list;
        }
	}
}