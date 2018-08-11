using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tut2
{
    public class GeneralParkingKiosk
    {
        private decimal _HoursParked;

        public decimal GeneralHoursParked  
        {
            get => _HoursParked;
            set
            {
                _HoursParked = value;
            }
        }

        public decimal FindGeneralParkingAmount() 
        {
            return _HoursParked * 2;  
        }
    }
}