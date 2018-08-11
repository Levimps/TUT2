using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tut2
{
    public class StudentParkingKiosk
    {
        private decimal _HoursParked;

        public decimal StudentHoursParked
        {
            get => default(int);
            set
            {
                _HoursParked = value;
            }
        }

        public decimal FindStudentParkingAmount()
        {
            return _HoursParked ;
        }
    }
}