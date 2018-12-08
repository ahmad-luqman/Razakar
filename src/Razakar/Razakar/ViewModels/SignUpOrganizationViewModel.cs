using System;
using System.Collections.Generic;
using System.Text;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.DataAnnotations;

namespace Razakar.ViewModels
{
    public class SignUpOrganizationViewModel : NotifyPropertyChangedBase
    {

        private string _name;
        private string _location = "Islamabad";
        private string _email;
        private string _phoneNumber;
        private string _representativeName;

        [DisplayOptions(Header = "Organization Name")]
        public string Name
        {
            get { return this._name; }
            set
            {
                if (value != this._name)
                {
                    this._name = value;
                    OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Header = "Representative Name")]
        public string RepresentativeName
        {
            get { return this._representativeName; }
            set
            {
                if (value != this._representativeName)
                {
                    this._representativeName = value;
                    OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Header = "Email Address")]
        public string Email
        {
            get { return this._email; }
            set
            {
                if (value != this._email)
                {
                    this._email = value;
                    OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Header = "Phone Number")]
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set
            {
                if (value != this._phoneNumber)
                {
                    this._phoneNumber = value;
                    OnPropertyChanged();
                }
            }
        }


        [DisplayOptions(Header = "Location")]
        [DataSourceKey("LocationSource")]
        public string Location
        {
            get => _location;
            set
            {
                if (value != _location)
                {
                    _location = value;
                    OnPropertyChanged();
                }
            }
        }

        public void Register()
        {

        }
    }
}
