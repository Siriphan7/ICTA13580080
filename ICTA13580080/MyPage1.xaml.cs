using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICTA13580080
{
    public partial class MyPage1 : ContentPage
    {
        public MyPage1()
        {
            InitializeComponent();
            nextButton.Clicked += NextButton_Clicked;
        }

        void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyPage2());

        }
    }
}
