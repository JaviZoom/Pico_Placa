using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pico_Placa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //timer to refresh the current day and time
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.hour.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy, HH:mm:ss");
        }
        //to close the application when clicked on Exit on File menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //to see the information about the aplication 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void submitbtn_Click(object sender, EventArgs e)
        {
            double morningStart = 07.00;//Start Time of Pico y placa in the morning
            double morningEnd = 09.30;//End Time of Pico y placa in the morning
            double afternoonStart = 16.00;//Start Time of Pico y placa in the afternoon
            double afternoonEnd = 19.30;//End Time of Pico y placa in the afternoon
            Regex regExpre = new Regex(@"^[A-Z]{3}[0-9]{4}"); //Regular expression to control plate input
            Regex regExpre2 = new Regex(@"^[A-Z]{2}[0-9]{4}");//Regular expression to control plate input 
            if (regExpre.IsMatch(platetxt.Text) || regExpre2.IsMatch(platetxt.Text)) //
            {
                //control of fields completed correctly
                if ((radioButton1.Checked == true || radioButton2.Checked == true))
                {
                    //control of fields completed correctly
                    if (comboBoxType.SelectedItem != null)
                    {
                        Data data = new Data(comboBoxType.Text.ToString(), platetxt.Text.ToString(), datetxt.Text.ToString(), timetxt.Text.Replace(":",".").ToString());
                        //if it is a holiday
                        if (radioButton1.Checked == true)
                        {
                            panelcolor.BackColor = Color.Lime;
                            paneltext.BackColor = Color.White;
                            panelcolor.BorderStyle = BorderStyle.FixedSingle;
                            paneltext.BorderStyle = BorderStyle.FixedSingle;
                            allowedlbl.Visible = true;
                            notallowedlbl.Visible = false;
                            infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because it is a Holiday.";
                            data.time.Replace(":", ".").ToString();
                        }
                        //if it is not a holiday
                        else if (radioButton2.Checked == true)
                        {
                            //if it is a private vehicle
                            if (comboBoxType.SelectedItem.ToString() == "Private Vehicle.")
                            {
                                switch (data.plate[data.plate.Length-1])
                                {
                                    //if the last digit of the license plate is 1
                                    case '1':
                                        if(data.date.Contains("lunes")|| data.date.Contains("monday"))
                                        {
                                            if ((Convert.ToDouble(data.time)>=morningStart && Convert.ToDouble(data.time)<=morningEnd) || (Convert.ToDouble(data.time) >= afternoonStart && Convert.ToDouble(data.time) <= afternoonEnd))
                                            {
                                                //information displayed if it is not allowed
                                                panelcolor.BackColor = Color.Red;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = false;
                                                notallowedlbl.Visible = true;
                                                infolbl.Text = "Hello, you can not drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because of Pico y Placa.";
                                                data.time.Replace(":", ".").ToString();
                                            }
                                            else
                                            {
                                                //information displayed if it is allowed
                                                panelcolor.BackColor = Color.Lime;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = true;
                                                notallowedlbl.Visible = false;
                                                infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString();
                                                data.time.Replace(":", ".").ToString();
                                            }
                                        }
                                        else
                                        {
                                            //information displayed if it is not monday
                                            panelcolor.BackColor = Color.Lime;
                                            paneltext.BackColor = Color.White;
                                            panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                            paneltext.BorderStyle = BorderStyle.FixedSingle;
                                            allowedlbl.Visible = true;
                                            notallowedlbl.Visible = false;
                                            infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because it is not Monday.";
                                            data.time.Replace(":", ".").ToString();
                                        }
                                        break;
                                    //if the last digit of the license plate is 2
                                    case '2':
                                        if (data.date.Contains("lunes") || data.date.Contains("monday"))
                                        {
                                            if ((Convert.ToDouble(data.time) >= morningStart && Convert.ToDouble(data.time) <= morningEnd) || (Convert.ToDouble(data.time) >= afternoonStart && Convert.ToDouble(data.time) <= afternoonEnd))
                                            {
                                                //information displayed if it is not allowed
                                                panelcolor.BackColor = Color.Red;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = false;
                                                notallowedlbl.Visible = true;
                                                infolbl.Text = "Hello, you can not drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because of Pico y Placa.";
                                                data.time.Replace(":", ".").ToString();

                                            }
                                            else
                                            {
                                                //information displayed if it is allowed
                                                panelcolor.BackColor = Color.Lime;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = true;
                                                notallowedlbl.Visible = false;
                                                infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString();
                                                data.time.Replace(":", ".").ToString();
                                            }
                                        }
                                        else
                                        {
                                            //information displayed if it is not monday
                                            panelcolor.BackColor = Color.Lime;
                                            paneltext.BackColor = Color.White;
                                            panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                            paneltext.BorderStyle = BorderStyle.FixedSingle;
                                            allowedlbl.Visible = true;
                                            notallowedlbl.Visible = false;
                                            infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because it is not Monday.";
                                            data.time.Replace(":", ".").ToString();
                                        }
                                        break;
                                    //if the last digit of the license plate is 2
                                    case '3':
                                        if (data.date.Contains("martes") || data.date.Contains("tuesday"))
                                        {
                                            if ((Convert.ToDouble(data.time) >= morningStart && Convert.ToDouble(data.time) <= morningEnd) || (Convert.ToDouble(data.time) >= afternoonStart && Convert.ToDouble(data.time) <= afternoonEnd))
                                            {
                                                //information displayed if it is not allowed
                                                panelcolor.BackColor = Color.Red;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = false;
                                                notallowedlbl.Visible = true;
                                                infolbl.Text = "Hello, you can not drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because of Pico y Placa.";
                                                data.time.Replace(":", ".").ToString();
                                            }
                                            else
                                            {
                                                //information displayed if it is allowed
                                                panelcolor.BackColor = Color.Lime;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = true;
                                                notallowedlbl.Visible = false;
                                                infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString();
                                                data.time.Replace(":", ".").ToString();
                                            }
                                        }
                                        else
                                        {
                                            //information displayed if it is not tuesday
                                            panelcolor.BackColor = Color.Lime;
                                            paneltext.BackColor = Color.White;
                                            panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                            paneltext.BorderStyle = BorderStyle.FixedSingle;
                                            allowedlbl.Visible = true;
                                            notallowedlbl.Visible = false;
                                            infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because it is not Tuesday.";
                                            data.time.Replace(":", ".").ToString();
                                        }
                                        break;
                                    //if the last digit of the license plate is 4
                                    case '4':
                                        if (data.date.Contains("martes") || data.date.Contains("tuesday"))
                                        {
                                            if ((Convert.ToDouble(data.time) >= morningStart && Convert.ToDouble(data.time) <= morningEnd) || (Convert.ToDouble(data.time) >= afternoonStart && Convert.ToDouble(data.time) <= afternoonEnd))
                                            {
                                                //information displayed if it is not allowed
                                                panelcolor.BackColor = Color.Red;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = false;
                                                notallowedlbl.Visible = true;
                                                infolbl.Text = "Hello, you can not drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because of Pico y Placa.";
                                                data.time.Replace(":", ".").ToString();
                                            }
                                            else
                                            {
                                                //information displayed if it is allowed
                                                panelcolor.BackColor = Color.Lime;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = true;
                                                notallowedlbl.Visible = false;
                                                infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString();
                                                data.time.Replace(":", ".").ToString();
                                            }
                                        }
                                        else
                                        {
                                            //information displayed if it is not tuesday
                                            panelcolor.BackColor = Color.Lime;
                                            paneltext.BackColor = Color.White;
                                            panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                            paneltext.BorderStyle = BorderStyle.FixedSingle;
                                            allowedlbl.Visible = true;
                                            notallowedlbl.Visible = false;
                                            infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because it is not Tuesday.";
                                            data.time.Replace(":", ".").ToString();
                                        }
                                        break;
                                    //if the last digit of the license plate is 5
                                    case '5':
                                        if (data.date.Contains("miércoles") || data.date.Contains("wednesday"))
                                        {
                                            if ((Convert.ToDouble(data.time) >= morningStart && Convert.ToDouble(data.time) <= morningEnd) || (Convert.ToDouble(data.time) >= afternoonStart && Convert.ToDouble(data.time) <= afternoonEnd))
                                            {
                                                //information displayed if it is not allowed
                                                panelcolor.BackColor = Color.Red;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = false;
                                                notallowedlbl.Visible = true;
                                                infolbl.Text = "Hello, you can not drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because of Pico y Placa.";
                                                data.time.Replace(":", ".").ToString();
                                            }
                                            else
                                            {
                                                //information displayed if it is allowed
                                                panelcolor.BackColor = Color.Lime;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = true;
                                                notallowedlbl.Visible = false;
                                                infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString();
                                                data.time.Replace(":", ".").ToString();
                                            }
                                        }
                                        else
                                        {
                                            //information displayed if it is not wednesday
                                            panelcolor.BackColor = Color.Lime;
                                            paneltext.BackColor = Color.White;
                                            panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                            paneltext.BorderStyle = BorderStyle.FixedSingle;
                                            allowedlbl.Visible = true;
                                            notallowedlbl.Visible = false;
                                            infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because it is not Wednesday.";
                                            data.time.Replace(":", ".").ToString();
                                        }
                                        break;
                                    //if the last digit of the license plate is 6
                                    case '6':
                                        if (data.date.Contains("miércoles") || data.date.Contains("wednesday"))
                                        {
                                            if ((Convert.ToDouble(data.time) >= morningStart && Convert.ToDouble(data.time) <= morningEnd) || (Convert.ToDouble(data.time) >= afternoonStart && Convert.ToDouble(data.time) <= afternoonEnd))
                                            {
                                                //information displayed if it is not allowed
                                                panelcolor.BackColor = Color.Red;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = false;
                                                notallowedlbl.Visible = true;
                                                infolbl.Text = "Hello, you can not drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because of Pico y Placa.";
                                                data.time.Replace(":", ".").ToString();
                                            }
                                            else
                                            {
                                                //information displayed if it is allowed
                                                panelcolor.BackColor = Color.Lime;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = true;
                                                notallowedlbl.Visible = false;
                                                infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString();
                                                data.time.Replace(":", ".").ToString();
                                            }
                                        }
                                        else
                                        {
                                            //information displayed if it is not wednesday
                                            panelcolor.BackColor = Color.Lime;
                                            paneltext.BackColor = Color.White;
                                            panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                            paneltext.BorderStyle = BorderStyle.FixedSingle;
                                            allowedlbl.Visible = true;
                                            notallowedlbl.Visible = false;
                                            infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because it is not Wednesday.";
                                            data.time.Replace(":", ".").ToString();
                                        }
                                        break;
                                    //if the last digit of the license plate is 7
                                    case '7':
                                        if (data.date.Contains("jueves") || data.date.Contains("thursday"))
                                        {
                                            if ((Convert.ToDouble(data.time) >= morningStart && Convert.ToDouble(data.time) <= morningEnd) || (Convert.ToDouble(data.time) >= afternoonStart && Convert.ToDouble(data.time) <= afternoonEnd))
                                            {
                                                //information displayed if it is not allowed
                                                panelcolor.BackColor = Color.Red;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = false;
                                                notallowedlbl.Visible = true;
                                                infolbl.Text = "Hello, you can not drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because of Pico y Placa.";
                                                data.time.Replace(":", ".").ToString();
                                            }
                                            else
                                            {
                                                //information displayed if it is allowed
                                                panelcolor.BackColor = Color.Lime;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = true;
                                                notallowedlbl.Visible = false;
                                                infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString();
                                                data.time.Replace(":", ".").ToString();
                                            }
                                        }
                                        else
                                        {
                                            //information displayed if it is not thursday
                                            panelcolor.BackColor = Color.Lime;
                                            paneltext.BackColor = Color.White;
                                            panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                            paneltext.BorderStyle = BorderStyle.FixedSingle;
                                            allowedlbl.Visible = true;
                                            notallowedlbl.Visible = false;
                                            infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because it is not Thursday.";
                                            data.time.Replace(":", ".").ToString();
                                        }
                                        break;
                                    //if the last digit of the license plate is 8
                                    case '8':
                                        if (data.date.Contains("jueves") || data.date.Contains("thursday"))
                                        {
                                            if ((Convert.ToDouble(data.time) >= morningStart && Convert.ToDouble(data.time) <= morningEnd) || (Convert.ToDouble(data.time) >= afternoonStart && Convert.ToDouble(data.time) <= afternoonEnd))
                                            {
                                                //information displayed if it is not allowed
                                                panelcolor.BackColor = Color.Red;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = false;
                                                notallowedlbl.Visible = true;
                                                infolbl.Text = "Hello, you can not drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because of Pico y Placa.";
                                                data.time.Replace(":", ".").ToString();
                                            }
                                            else
                                            {
                                                //information displayed if it is allowed
                                                panelcolor.BackColor = Color.Lime;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = true;
                                                notallowedlbl.Visible = false;
                                                infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString();
                                                data.time.Replace(":", ".").ToString();
                                            }
                                        }
                                        else
                                        {
                                            //information displayed if it is not thursday
                                            panelcolor.BackColor = Color.Lime;
                                            paneltext.BackColor = Color.White;
                                            panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                            paneltext.BorderStyle = BorderStyle.FixedSingle;
                                            allowedlbl.Visible = true;
                                            notallowedlbl.Visible = false;
                                            infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because it is not Thursday.";
                                            data.time.Replace(":", ".").ToString();
                                        }
                                        break;
                                    //if the last digit of the license plate is 9
                                    case '9':
                                        if (data.date.Contains("viernes") || data.date.Contains("friday"))
                                        {
                                            if ((Convert.ToDouble(data.time) >= morningStart && Convert.ToDouble(data.time) <= morningEnd) || (Convert.ToDouble(data.time) >= afternoonStart && Convert.ToDouble(data.time) <= afternoonEnd))
                                            {
                                                //information displayed if it is not allowed
                                                panelcolor.BackColor = Color.Red;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = false;
                                                notallowedlbl.Visible = true;
                                                infolbl.Text = "Hello, you can not drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because of Pico y Placa.";
                                                data.time.Replace(":", ".").ToString();
                                            }
                                            else
                                            {
                                                //information displayed if it is allowed
                                                panelcolor.BackColor = Color.Lime;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = true;
                                                notallowedlbl.Visible = false;
                                                infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString();
                                                data.time.Replace(":", ".").ToString();
                                            }
                                        }
                                        else
                                        {
                                            //information displayed if it is not friday
                                            panelcolor.BackColor = Color.Lime;
                                            paneltext.BackColor = Color.White;
                                            panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                            paneltext.BorderStyle = BorderStyle.FixedSingle;
                                            allowedlbl.Visible = true;
                                            notallowedlbl.Visible = false;
                                            infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because it is not Friday.";
                                            data.time.Replace(":", ".").ToString();
                                        }
                                        break;
                                    //if the last digit of the license plate is 0
                                    case '0':
                                        if (data.date.Contains("viernes") || data.date.Contains("friday"))
                                        {
                                            if ((Convert.ToDouble(data.time) >= morningStart && Convert.ToDouble(data.time) <= morningEnd) || (Convert.ToDouble(data.time) >= afternoonStart && Convert.ToDouble(data.time) <= afternoonEnd))
                                            {
                                                //information displayed if it is not allowed
                                                panelcolor.BackColor = Color.Red;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = false;
                                                notallowedlbl.Visible = true;
                                                infolbl.Text = "Hello, you can not drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because of Pico y Placa.";
                                                data.time.Replace(":", ".").ToString();
                                            }
                                            else
                                            {
                                                //information displayed if it is allowed
                                                panelcolor.BackColor = Color.Lime;
                                                paneltext.BackColor = Color.White;
                                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                                allowedlbl.Visible = true;
                                                notallowedlbl.Visible = false;
                                                infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString();
                                                data.time.Replace(":", ".").ToString();
                                            }
                                        }
                                        else
                                        {
                                            //information displayed if it is not friday
                                            panelcolor.BackColor = Color.Lime;
                                            paneltext.BackColor = Color.White;
                                            panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                            paneltext.BorderStyle = BorderStyle.FixedSingle;
                                            allowedlbl.Visible = true;
                                            notallowedlbl.Visible = false;
                                            infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time.Replace(".", ":").ToString() + ", because it is not Friday.";
                                            data.time.Replace(":", ".").ToString();
                                        }
                                        break;
                                }
                            }
                            else
                            {
                                panelcolor.BackColor = Color.Lime;
                                paneltext.BackColor = Color.White;
                                panelcolor.BorderStyle = BorderStyle.FixedSingle;
                                paneltext.BorderStyle = BorderStyle.FixedSingle;
                                allowedlbl.Visible = true;
                                notallowedlbl.Visible = false;
                                infolbl.Text = "Hello, you can drive your vehicle this day: " + data.date + ", and at this time: " + data.time + ", because you have this type of vehicle: "+ data.typeVehicle;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select a vehicle type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Select \"Yes\" or \"No\" on \"Holiday\"", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("License Plate must have this structure \"AAA9999 or AA9999\"", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //license plate to uppercase
        private void platetxt_TextChanged(object sender, EventArgs e)
        {
            platetxt.Text = platetxt.Text.ToUpper();
            platetxt.SelectionStart = platetxt.Text.Length;
        }
    }
}