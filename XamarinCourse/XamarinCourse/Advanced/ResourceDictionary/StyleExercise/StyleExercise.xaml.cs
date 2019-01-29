using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.Advanced.ResourceDictionary.StyleExercise
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StyleExercise : ContentPage
	{
        private void Button_OnClicked(object sender, EventArgs e)
        {
            var number = ((Button)sender).Text;
            DialLabel.Text += number;
        }

        public StyleExercise ()
		{
			InitializeComponent ();
		}
	}
}