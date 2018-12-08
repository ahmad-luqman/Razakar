using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Razakar.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Razakar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Authentication:
                        MenuPages.Add(id, new NavigationPage(new AuthenticationPage()));
                        break;
                    case (int)MenuItemType.SignUpOrganization:
                        MenuPages.Add(id, new NavigationPage(new SignUpOrganizationPage()));
                        break;
                    case (int)MenuItemType.SignUpRazakar:
                        MenuPages.Add(id, new NavigationPage(new SignUpVolunteerPage()));
                        break;
                    case (int)MenuItemType.RequestRazakar:
                        MenuPages.Add(id, new NavigationPage(new RequestRazakarPage()));
                        break;
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}