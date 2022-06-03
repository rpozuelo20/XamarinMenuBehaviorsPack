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
            /*  BehaviorsPack:
            -   Con 'BehaviorsPack' podemos "realizar eventos desde el mismo menu?", tipo,
            -   tenemos un perfil, y queremos que si el usuario no esta logueado le aparezca
            -   un boton para loguearse, en caso contrario, le mostrara un boton para el perfil.
            -
            -   Tenemos que tocar los siguientes archivos para poder utilizar correctamente el NuGet:
            -       .MasterPageItem.cs (en carpeta Code)
            -       .ServiceIoC.cs (en carpeta Services)
            -       .MainMenuView.xaml (en carpeta Views)
            -       .MainMenuView.xaml.cs (en carpeta Views)
            -       .MainMenuViewModel.cs (en carpeta ViewModels)
            -       .App.xaml.cs (raiz del proyecto)
            -
            -   Ademas, debemos de disponer del archivo ViewModelBase (los ViewModels heredan de este),
            -   los NuGets de Autofac y BehaviorsPack, el ServiceLocator en App.xaml.cs...
            */
            MainMenuView mainMenu = App.ServiceLocator.MainMenuView;
            mainMenu.Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MainPage)));
            MainPage = mainMenu;
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
