using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamarinMenuBehaviorsPack.Base;
using XamarinMenuBehaviorsPack.Code;
using XamarinMenuBehaviorsPack.Views;

namespace XamarinMenuBehaviorsPack.ViewModels
{
    public class MainMenuViewModel:ViewModelBase
    {
        public MainMenuViewModel()
        {
            ObservableCollection<MasterPageItem> menu = new ObservableCollection<MasterPageItem>
            {
                new MasterPageItem
                {
                    Titulo="Home",
                    Tipo=typeof(HomeView),
                    Descripcion="Link to the home.",
                    Icono="home.png"
                },
                new MasterPageItem
                {
                    Titulo="Phone",
                    Tipo=typeof(PhoneView),
                    Descripcion="Link to the phone.",
                    Icono="phone.png"
                },
                new MasterPageItem
                {
                    Titulo="Store",
                    Tipo=typeof(StoreView),
                    Descripcion="Link to the store.",
                    Icono="store.png"
                }
            };
            this.MenuPrincipal = menu;
        }
        private ObservableCollection<MasterPageItem> _MenuPrincipal;
        public ObservableCollection<MasterPageItem> MenuPrincipal
        {
            get { return this._MenuPrincipal; }
            set
            {
                this._MenuPrincipal = value;
                OnPropertyChanged("MenuPrincipal");
            }
        }
        //  Comando para devolver la vista que se ha seleccionado en el menu:
        public Command PaginaSeleccionada
        {
            get
            {
                return new Command((seleccionado) => {
                    MainMenuView masterPage = App.ServiceLocator.MainMenuView;
                    var item = (MasterPageItem)seleccionado;
                    var tipo = item.Tipo;
                    masterPage.Detail = new NavigationPage((Page)Activator.CreateInstance(tipo));
                    masterPage.IsPresented = false;
                });
            }
        }
    }
}
