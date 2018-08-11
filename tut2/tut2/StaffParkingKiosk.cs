using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tut2
{
    public class StaffParkingKiosk
    {
        private decimal _HoursParked;

        public decimal StaffHoursParked
        {
            get => _HoursParked;
            set
            {
                _HoursParked = value;
            }
        }

        public decimal FindStaffParkingAmount()
        {
            if(_HoursParked < 10)
            {
                return 2;
            }
            else
            {
                return 2 + 2 * (_HoursParked - 10);
            }
        }
    }
}