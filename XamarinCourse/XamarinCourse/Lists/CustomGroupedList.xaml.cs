using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCourse.Models;

namespace XamarinCourse.Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomGroupedList : ContentPage
    {
        public CustomGroupedList()
        {
            InitializeComponent();

            var list = new List<ContactGroup>()
            {
                new ContactGroup("U","U")
                {
                    new Contact() {Name = "Umberto", Slogan = "I am here", ImageUrl = ImageSource.FromUri(new Uri("http://lorempixel.com/100/100/people/1"))},
                    new Contact() {Name = "Umberto2", Slogan = "I am here", ImageUrl = ImageSource.FromUri(new Uri("http://lorempixel.com/100/100/people/1"))},
                },
                new ContactGroup("J", "J")
                {
                new Contact() {Name = "John", Slogan = "I am there", ImageUrl = ImageSource.FromUri(new Uri("http://lorempixel.com/100/100/people/2"))},
                new Contact() {Name = "John2", Slogan = "I am there", ImageUrl = ImageSource.FromUri(new Uri("http://lorempixel.com/100/100/people/2"))},
                }
            };

            GroupedList.ItemsSource = list;
        }
    }
}