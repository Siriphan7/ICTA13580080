﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICTA13580080
{
    public partial class MyPage3 : ContentPage
    {
        public MyPage3()
        {
            InitializeComponent();
            backButton.Clicked += BackButton_Clicked;
        }

        void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
