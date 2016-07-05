using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string name = "";
        int day = 0;
        int years = 0;
        string month = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get name tex box
            name = textBox1.Text;
            //get today's date
            DateTime today = DateTime.Now.Date;
            //get the difference in days betweeen today's date

            // get the date in the date time picker
            TimeSpan ageDays = today - dateTimePicker1.Value;

            //work out age in years
            years = ((int)ageDays.TotalDays) / 365;

            //get the day and month from the datetime picker
            day = dateTimePicker1.Value.Day;
            month = dateTimePicker1.Value.ToString("MMMM"); 

            labelMessage.Text = "Hello, "  + name + " You will be " + years + " yeras old on " + day + " " + month + ".";
        }
    }
}
