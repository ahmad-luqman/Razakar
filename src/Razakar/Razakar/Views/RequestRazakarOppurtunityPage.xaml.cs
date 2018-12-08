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
    public partial class RequestRazakarOppurtunityPage : ContentPage
    {
        public RequestRazakarOppurtunityPage()
        {
            InitializeComponent();

            dataForm.RegisterEditor(nameof(RequestRazakarOppurtunityViewModel.Date), EditorType.DateEditor);
            dataForm.RegisterEditor(nameof(RequestRazakarOppurtunityViewModel.Time), EditorType.TimeEditor);
            dataForm.RegisterEditor(nameof(RequestRazakarOppurtunityViewModel.Duration), EditorType.NumberPickerEditor);
            dataForm.RegisterEditor(nameof(RequestRazakarOppurtunityViewModel.Expertise), EditorType.TextEditor);
            dataForm.RegisterEditor(nameof(RequestRazakarOppurtunityViewModel.Details), EditorType.TextEditor);
        }

        private void Request_Clicked(object sender, EventArgs e)
        {
            ((RequestRazakarOppurtunityViewModel)dataForm.Source).Request();
        }
    }
}