﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.Essentials
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EssentialsPage : ContentPage
	{
        private readonly IList<string> _quotes;
        private int _quoteIndex = 0;

        public EssentialsPage()
        {
            _quotes = new List<string>()
            {
                "quote 1",
                "quote 2",
                "quote 3",
                "quote 4",
                "quote 5"
            };
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            this.LabelQuote.Text = _quotes[_quoteIndex];
            _quoteIndex++;
            if (_quoteIndex == _quotes.Count)
            {
                _quoteIndex = 0;
            }
        }
    }
}