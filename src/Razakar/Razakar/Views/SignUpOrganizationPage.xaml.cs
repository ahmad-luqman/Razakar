using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Razakar.ViewModels;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Razakar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpOrganizationPage : ContentPage
    {
        private SignUpOrganizationViewModel viewModel;
        public SignUpOrganizationPage()
        {
            InitializeComponent();

            dataForm.PropertyDataSourceProvider = new OptionsProvider();
            dataForm.RegisterEditor(nameof(SignUpOrganizationViewModel.Name), EditorType.TextEditor);
            dataForm.RegisterEditor(nameof(SignUpOrganizationViewModel.Location), EditorType.PickerEditor);
        }

        private void Register_Clicked(object sender, EventArgs e)
        {
            ((SignUpOrganizationViewModel)dataForm.Source).Register();
        }
    }
}