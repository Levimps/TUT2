using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tut2
{
    public class StaffKioskWrap : Ikiosk
    {
        private StaffParkingKiosk _StaffParking;

        public StaffKioskWrap(decimal hour)
        {
            _StaffParking = new StaffParkingKiosk();
            _StaffParking.StaffHoursParked = hour;
        }

        public decimal HoursParked { get => _StaffParking.StaffHoursParked;  }

    /*    public StaffParkingKiosk StaffParkingKiosk
        {
            get => default(StaffParkingKiosk);

        }*/

        public decimal FindParkingAmount()
        {
            return _StaffParking.FindStaffParkingAmount();
        }
    }
}