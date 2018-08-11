using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tut2
{
    public class ActualParkType
    {
        private int _myType;

        public int MyType
        {
            get => default(int);
            set
            {
            }
        }

        public int ShowType()
        {
            return Convert.ToInt16(MyType);
        }
    }
}