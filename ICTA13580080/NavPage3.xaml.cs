using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICTA13580080
{
    public partial class NavPage3 : ContentPage
    {
        public NavPage3()
        {
            InitializeComponent();
            backToButton.Clicked += BackToButton_Clicked;
            backToRoot.Clicked += BackToRoot_Clicked;
        }

        void BackToButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        void BackToRoot_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}
