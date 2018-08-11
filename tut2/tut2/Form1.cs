using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tut2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void groupBox1_Enter(object sender, EventArgs e)
        {
             
        }


        ParkType pt;
        Ikiosk _obj;
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            decimal hours = Convert.ToDecimal(tbHours.Text);
            decimal Hours = Math.Ceiling(hours);       //double 16?

            if (rbGeneral.Checked)
            {
                //pt = ParkType.General;
                
                _obj = new GenKioskWrap(Hours);   //another constructor
                lblOutput.Text = _obj.FindParkingAmount().ToString();


            }
            if (rbStudent.Checked)
            {
                pt = ParkType.Student;

                _obj = new StudKioskWrap(Hours);
                lblOutput.Text = _obj.FindParkingAmount().ToString();

            }

            if (rbStaff.Checked)
            {
                pt = ParkType.Staff;

                _obj = new StaffKioskWrap(Hours);
                lblOutput.Text = _obj.FindParkingAmount().ToString();

            }

        }


        private void rbGeneral_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
