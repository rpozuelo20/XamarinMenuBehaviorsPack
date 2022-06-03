using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMenuBehaviorsPack.Code;

namespace XamarinMenuBehaviorsPack.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenuView : MasterDetailPage
    {
        public MainMenuView()
        {
            InitializeComponent();
            /*  ¡¡¡YA NO ES NECESARIO USAR EL CONSTRUCTOR Y EL COMANDO, LO HACEMOS DIRECTAMENTE DESDE EL VIEWMODEL!!!
            
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
            this.lsvMenu.ItemsSource = menu;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MainPage)));
            this.lsvMenu.ItemSelected += LsvMenu_ItemSelected; ;
             */
        }

        /*
         private void LsvMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type type = item.Tipo;
            Detail = new NavigationPage((Page)Activator.CreateInstance(type));
            IsPresented = false;
        }
         */
    }
}