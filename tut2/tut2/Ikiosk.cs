using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tut2
{
    public interface Ikiosk
    {
        decimal HoursParked { get; }

        decimal FindParkingAmount();
    }
}