using System;
using System.Collections.Generic;
using System.Text;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.DataAnnotations;

namespace Razakar.ViewModels
{
    public class RequestRazakarViewModel : NotifyPropertyChangedBase
    {
        private DateTime _date = DateTime.Now;
        private DateTime _time = DateTime.Now;
        private double _duration;
        private string _expertise;
        private string _details;
        const double Tolerance = double.Epsilon*100;

        [DisplayOptions(Header = "Date")]
        public DateTime Date
        {
            get { return this._date; }
            set
            {
                if (value != this._date)
                {
                    this._date = value;
                    OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Header = "Time")]
        public DateTime Time
        {
            get { return this._time; }
            set
            {
                if (value != this._time)
                {
                    this._time = value;
                    OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Header = "Duration")]
        public double Duration
        {
            get { return this._duration; }
            set
            {
                if (Math.Abs(value - this._duration) > Tolerance)
                {
                    this._duration = value;
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

        [DisplayOptions(Header = "Details")]
        public string Details
        {
            get => _details;
            set
            {
                if (value != _details)
                {
                    _details = value;
                    OnPropertyChanged();
                }
            }
        }

        public void Request()
        {
            //throw new NotImplementedException();
        }
    }
}
