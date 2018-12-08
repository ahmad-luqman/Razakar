using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.DataAnnotations;
using Telerik.XamarinForms.Input.DataForm;

namespace Razakar.ViewModels
{
    public class OptionsProvider : PropertyDataSourceProvider
    {
        public override IList GetSourceForKey(object key)
        {
            if (key.ToString() == "QualificationSource")
            {
                return new List<string>
                {
                    "Intermediate",
                    "Bachelors",
                    "Masters",
                    "MPhil",
                    "Phd"
                };
            }

            if (key.ToString() == "GenderSource")
            {
                return new List<string>
                {
                    "Male",
                    "Female"
                };
            }

            if (key.ToString() == "LocationSource")
            {
                return new List<string>
                {
                    "Islamabad",
                    "Rawalpindi",
                    "Lahore"
                };
            }

            return null;
        }
    }
    public class SignUpRazakarViewModel : NotifyPropertyChangedBase
    {
        private string _name;
        private string _gender = "Male";
        private string _qualification;
        private string _occupation;
        private string _expertise;
        private string _location = "Islamabad";
        private string _email;
        private string _phoneNumber;

        [DisplayOptions(Header = "Razakar Name")]
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


        [DisplayOptions(Header = "Gender")]
        [DataSourceKey("GenderSource")]
        public string Gender
        {
            get { return this._gender; }
            set
            {
                if (value != this._gender)
                {
                    this._gender = value;
                    OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Header = "Qualification")]
        [DataSourceKey("QualificationSource")]
        public string Qualification
        {
            get => _qualification;
            set
            {
                if (value != _qualification)
                {
                    _qualification = value;
                    OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Header = "Occupation")]
        public string Occupation
        {
            get => _occupation;
            set
            {
                if (value != _occupation)
                {
                    _occupation = value;
                    OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Header = "Expertise")]
        public string Expertise
        {
            get => _expertise;
            set
            {
                if (value != _expertise)
                {
                    _expertise = value;
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
