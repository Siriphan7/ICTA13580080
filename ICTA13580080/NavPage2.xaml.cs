using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICTA13580080
{
    public partial class NavPage2 : ContentPage
    {
        public NavPage2()
        {
            InitializeComponent();
            backButton.Clicked += BackButton_Clicked;
            nextButton.Clicked += NextButton_Clicked;
        }

        void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavPage3());
        }
    }
}
