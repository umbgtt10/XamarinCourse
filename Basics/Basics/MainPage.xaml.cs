using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Basics
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;

                case Device.Android:
                    Padding = new Thickness(0, 0, 0, 0);
                    break;

                case Device.UWP:
                    Padding = new Thickness(0, 0, 0, 0);
                    break;
            }
        }
    }
}
