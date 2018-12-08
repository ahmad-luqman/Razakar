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
    public partial class SignUpVolunteerPage : ContentPage
    {
        public SignUpVolunteerPage()
        {
            InitializeComponent();

            dataForm.PropertyDataSourceProvider = new OptionsProvider();
            dataForm.RegisterEditor(nameof(SignUpRazakarViewModel.Name), EditorType.TextEditor);
            dataForm.RegisterEditor(nameof(SignUpRazakarViewModel.Gender), EditorType.PickerEditor);
            dataForm.RegisterEditor(nameof(SignUpRazakarViewModel.Qualification), EditorType.PickerEditor);
            dataForm.RegisterEditor(nameof(SignUpRazakarViewModel.Occupation), EditorType.TextEditor);
            dataForm.RegisterEditor(nameof(SignUpRazakarViewModel.Expertise), EditorType.TextEditor);
            dataForm.RegisterEditor(nameof(SignUpRazakarViewModel.Location), EditorType.PickerEditor);
        }

        private void Register_Clicked(object sender, EventArgs e)
        {
            ((SignUpRazakarViewModel)dataForm.Source).Register();
        }
    }
}