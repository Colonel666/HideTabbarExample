using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace HideTabbarExample
{
    public class MyPageViewModel
    {
        public MyPageViewModel()
        {
            PushDetailPageWithoutTabbarCommand = new Command(() => PushWithoutNavbar());
        }

        public ICommand PushDetailPageWithoutTabbarCommand { get; set; }

        void PushWithoutNavbar ()
        {
            App.Current.MainPage.Navigation.PushAsync(new MyPage());
        }
    }
}

