using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tut2
{
    public class StudKioskWrap : Ikiosk
    {
        private StudentParkingKiosk _StudentParking;

        public StudKioskWrap(decimal hour)
        {
            _StudentParking = new StudentParkingKiosk();
            _StudentParking.StudentHoursParked = hour;
        }

        public StudentParkingKiosk StudentParkingKiosk
        {
            get => default(StudentParkingKiosk);
           
        }

        public decimal HoursParked { get => _StudentParking.StudentHoursParked; }

        public decimal FindParkingAmount()
        {
            return _StudentParking.FindStudentParkingAmount();
        }
    }
}