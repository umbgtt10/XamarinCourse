using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.Layouts.Grid
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GridExercise1 : ContentPage
	{
		public GridExercise1 ()
		{
			InitializeComponent ();
		}

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var number = ((Button) sender).Text;
            DialLabel.Text += number;
        }
    }
}