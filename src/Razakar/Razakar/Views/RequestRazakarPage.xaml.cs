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
    public partial class RequestRazakarPage : ContentPage
    {
        public RequestRazakarPage()
        {
            InitializeComponent();

            dataForm.RegisterEditor(nameof(RequestRazakarViewModel.Date), EditorType.DateEditor);
            dataForm.RegisterEditor(nameof(RequestRazakarViewModel.Time), EditorType.TimeEditor);
            dataForm.RegisterEditor(nameof(RequestRazakarViewModel.Duration), EditorType.NumberPickerEditor);
            dataForm.RegisterEditor(nameof(RequestRazakarViewModel.Expertise), EditorType.TextEditor);
            dataForm.RegisterEditor(nameof(RequestRazakarViewModel.Details), EditorType.TextEditor);
        }

        private void Request_Clicked(object sender, EventArgs e)
        {
            ((RequestRazakarViewModel)dataForm.Source).Request();
        }
    }
}