using System;
using System.Collections.Generic;
using Razakar.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Razakar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Authentication, Title="Google SignIn" },
                new HomeMenuItem {Id = MenuItemType.SignUpOrganization, Title="Organization SignUp" },
                new HomeMenuItem {Id = MenuItemType.SignUpRazakar, Title="Razakar SignUp" },
                new HomeMenuItem {Id = MenuItemType.RequestRazakar, Title="Request For Razakar" },
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}