using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tut2
{
    public class GenKioskWrap : Ikiosk

    {
        private GeneralParkingKiosk _GeneralParking;  //???   resource 



        public GenKioskWrap(decimal hour)    //constructor
        {
            _GeneralParking = new GeneralParkingKiosk();  
            _GeneralParking.GeneralHoursParked = hour; 


        }
        public decimal FindParkingAmount()    //method
        {
            return _GeneralParking.FindGeneralParkingAmount();                      
        }                
        
        //findParkingAmount and HoursParked are from interface then Kiosk
         
        public decimal HoursParked { get => _GeneralParking.GeneralHoursParked; }  //property 
                                                                                   



        public GeneralParkingKiosk GeneralParkingKiosk    //association
        {
            get => default(GeneralParkingKiosk);
            set
            {
            }
        }



    }
}