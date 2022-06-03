using Autofac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using XamarinMenuBehaviorsPack.ViewModels;
using XamarinMenuBehaviorsPack.Views;

namespace XamarinMenuBehaviorsPack.Services
{
    //  NuGet de 'Autofac' necesario para poder tener nuestro 'ServiceIoC'.
    //  Ademas, tenemos que implementar 'ServiceIoC' dentro de nuestro 'App.xaml.cs'.
    public class ServiceIoC
    {
        private void RegisterDependencies()
        {
            ContainerBuilder builder = new ContainerBuilder();
            //  Desde aqui configuramos las views, viewmodels y services...:
            builder.RegisterType<MainMenuView>().SingleInstance();
            builder.RegisterType<MainMenuViewModel>();
            this._Container = builder.Build();
        }

        private Autofac.IContainer _Container;
        public ServiceIoC()
        {
            this.RegisterDependencies();
        }
        //  Desde aqui indicamos las views, viewmodels y services...:
        public MainMenuView MainMenuView
        {
            get
            {
                return this._Container.Resolve<MainMenuView>();
            }
        }
        public MainMenuViewModel MainMenuViewModel
        {
            get
            {
                return this._Container.Resolve<MainMenuViewModel>();
            }
        }
    }
}
