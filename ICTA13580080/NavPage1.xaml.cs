using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICTA13580080
{
    public partial class NavPage1 : ContentPage
    {
        public NavPage1()
        {
            InitializeComponent();
            nextButton.Clicked += NextButton_Clicked;

        }

        void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavPage2());
        }
    }
}
