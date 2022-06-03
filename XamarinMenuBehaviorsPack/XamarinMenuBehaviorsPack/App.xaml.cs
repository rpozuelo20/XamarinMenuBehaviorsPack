using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMenuBehaviorsPack.Services;
using XamarinMenuBehaviorsPack.Views;

namespace XamarinMenuBehaviorsPack
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainMenuView();
        }
        private static ServiceIoC _ServiceLocator;
        public static ServiceIoC ServiceLocator
        {
            get
            {
                return _ServiceLocator = _ServiceLocator ?? new ServiceIoC();
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
