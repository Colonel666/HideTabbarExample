﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HideTabbarExample
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
            BindingContext = new MyPageViewModel();
        }
    }
}
