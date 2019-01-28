﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.Forms.TableView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactMethodsPage : ContentPage
    {
        public ListView ContactMethods
        {
            get { return ThisListView; }
        }

        public ContactMethodsPage()
        {
            InitializeComponent();

            ThisListView.ItemsSource = new List<string>()
            {
                "None",
                "Email",
                "SMS"
            };
        }
    }
}