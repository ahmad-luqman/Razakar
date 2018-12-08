using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Razakar.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Auth;


namespace Razakar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthenticationPage : ContentPage
    {
        private AuthenticationViewModel viewModel;
        private OAuth2Authenticator auth;
        public AuthenticationPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new AuthenticationViewModel();
            //auth = new OAuth2Authenticator
            //(
            //    clientId: "App ID from https://developers.facebook.com/apps",
            //    scope: "",
            //    authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
            //    redirectUrl: new Uri("http://www.facebook.com/connect/login_success.html"),
            //    // switch for new Native UI API
            //    //      true = Android Custom Tabs and/or iOS Safari View Controller
            //    //      false = Embedded Browsers used (Android WebView, iOS UIWebView)
            //    //  default = false  (not using NEW native UI)
            //    isUsingNativeUI: use_native_ui
            //);

        }

        async void GoogleSignIn_Clicked(object sender, EventArgs eventArgs)
        {
            viewModel.GoogleSignIn_Clicked();
        }
    }
}