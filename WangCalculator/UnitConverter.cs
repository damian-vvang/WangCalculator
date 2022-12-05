using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WangCalculator
{
    public partial class UnitConverter : Form
    {
        int keyboardButton_counter = 0;

        //Expression input state 
        bool enter_value = false; 

        public UnitConverter()
        {
            InitializeComponent();
            unitType.SelectedIndex = 0;
        }

        //Keyboard - Button
        private void button_keyboard_Click(object sender, EventArgs e)
        {
            ++keyboardButton_counter;
            switch (keyboardButton_counter)
            {
                case 1:
                    this.Width = 611;
                    keyboardLight.BackColor = Color.Red;
                    break;
                case 2:
                    this.Width = 1214;
                    keyboardLight.BackColor = Color.Green;
                    keyboardButton_counter = 0;
                    break;
            }
        }

        private void numbers_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            //Start value (zero) handling.
            if ((unitIn_value.Text == "0") || (enter_value))
                unitIn_value.Text = "";
            enter_value = false;

            //Decimal part handling.
            if (button.Text == ".")
            {
                if (!unitIn_value.Text.Contains(".")) 
                    unitIn_value.Text = unitIn_value.Text + button.Text;
            }
            else
            {
                unitIn_value.Text = unitIn_value.Text + button.Text;
            }
        }
        //Backspace - Button
        private void button_backspace_Click(object sender, EventArgs e)               
        {
            if (unitIn_value.Text.Length > 1)
                unitIn_value.Text = unitIn_value.Text.Remove(unitIn_value.Text.Length - 1, 1);
            else
                unitIn_value.Text = "0";
        }
       //Calculate - Button
        private void button_calculate_Click(object sender, EventArgs e)
        {
        string current1 = unitIn.SelectedItem.ToString();
        string current2 = unitOut.SelectedItem.ToString();
        double value = Convert.ToDouble(unitIn_value.Text);

            if (current1 == "<Select>" || current2 == "<Select>")
               result_value.Text = Convert.ToString("No units selected!");

            //g

            if (current1 == "g" && current2 == "g")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "g" && current2 == "dag")
                result_value.Text = Convert.ToString(value / 10);

            else if (current1 == "g" && current2 == "kg")
                result_value.Text = Convert.ToString(value / 1000);

            else if (current1 == "g" && current2 == "t")
                result_value.Text = Convert.ToString(value / 1000000);

            //dag

            else if (current1 == "dag" && current2 == "g")
                result_value.Text = Convert.ToString(value * 10);

            else if (current1 == "dag" && current2 == "dag")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "dag" && current2 == "kg")
                result_value.Text = Convert.ToString(value / 100);

            else if (current1 == "dag" && current2 == "t")
                result_value.Text = Convert.ToString(value / 100000);

            //kg

            else if (current1 == "kg" && current2 == "g")
                result_value.Text = Convert.ToString(value * 1000);

            else if (current1 == "kg" && current2 == "dag")
                result_value.Text = Convert.ToString(value * 100);

            else if (current1 == "kg" && current2 == "kg")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "kg" && current2 == "t")
                result_value.Text = Convert.ToString(value / 1000);

            //t

            else if (current1 == "t" && current2 == "g")
                result_value.Text = Convert.ToString(value * 1000000);

            else if (current1 == "t" && current2 == "dag")
                result_value.Text = Convert.ToString(value * 100000);

            else if (current1 == "t" && current2 == "kg")
                result_value.Text = Convert.ToString(value * 1000);

            else if (current1 == "t" && current2 == "t")
                result_value.Text = Convert.ToString(value);

            //Milliseconds

            else if (current1 == "Milliseconds" && current2 == "Milliseconds")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "Milliseconds" && current2 == "Seconds")
                result_value.Text = Convert.ToString(value / 1000);

            else if (current1 == "Milliseconds" && current2 == "Minutes")
                result_value.Text = Convert.ToString(value / 60000);

            else if (current1 == "Milliseconds" && current2 == "Hours")
                result_value.Text = Convert.ToString(value / 3600000);

            //Seconds

            else if (current1 == "Seconds" && current2 == "Milliseconds")
                result_value.Text = Convert.ToString(value / 1000);

            else if (current1 == "Seconds" && current2 == "Seconds")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "Seconds" && current2 == "Minutes")
                result_value.Text = Convert.ToString(value / 60);

            else if (current1 == "Seconds" && current2 == "Hours")
                result_value.Text = Convert.ToString(value / 3600);

            //Minutes

            else if (current1 == "Minutes" && current2 == "Milliseconds")
                result_value.Text = Convert.ToString(value * 60000);

            else if (current1 == "Minutes" && current2 == "Seconds")
                result_value.Text = Convert.ToString(value * 60);

            else if (current1 == "Minutes" && current2 == "Minutes")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "Minutes" && current2 == "Hours")
                result_value.Text = Convert.ToString(value / 60);

            //Hours

            else if (current1 == "Hours" && current2 == "Milliseconds")
                result_value.Text = Convert.ToString(value * 3600000);

            else if (current1 == "Hours" && current2 == "Seconds")
                result_value.Text = Convert.ToString(value * 3600);

            else if (current1 == "Hours" && current2 == "Minutes")
                result_value.Text = Convert.ToString(value * 60);

            else if (current1 == "Hours" && current2 == "Hours")
                result_value.Text = Convert.ToString(value);

            //mm

            else if (current1 == "mm" && current2 == "mm")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "mm" && current2 == "cm")
                result_value.Text = Convert.ToString(value / 10);

            else if (current1 == "mm" && current2 == "dm")
                result_value.Text = Convert.ToString(value / 100);

            else if (current1 == "mm" && current2 == "m")
                result_value.Text = Convert.ToString(value / 1000);

            else if (current1 == "mm" && current2 == "km")
                result_value.Text = Convert.ToString(value / 1000000);

            //cm

            else if (current1 == "cm" && current2 == "mm")
                result_value.Text = Convert.ToString(value * 10);

            else if (current1 == "cm" && current2 == "cm")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "cm" && current2 == "dm")
                result_value.Text = Convert.ToString(value / 10);

            else if (current1 == "cm" && current2 == "m")
                result_value.Text = Convert.ToString(value / 100);

            else if (current1 == "cm" && current2 == "km")
                result_value.Text = Convert.ToString(value / 10000);

            //dm

            else if (current1 == "dm" && current2 == "mm")
                result_value.Text = Convert.ToString(value * 100);

            else if (current1 == "dm" && current2 == "cm")
                result_value.Text = Convert.ToString(value * 10);

            else if (current1 == "dm" && current2 == "dm")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "dm" && current2 == "m")
                result_value.Text = Convert.ToString(value / 10);

            else if (current1 == "dm" && current2 == "km")
                result_value.Text = Convert.ToString(value / 10000);

            //m

            else if (current1 == "m" && current2 == "mm")
                result_value.Text = Convert.ToString(value * 1000);

            else if (current1 == "m" && current2 == "cm")
                result_value.Text = Convert.ToString(value * 100);

            else if (current1 == "m" && current2 == "dm")
                result_value.Text = Convert.ToString(value * 10);

            else if (current1 == "m" && current2 == "m")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "m" && current2 == "km")
                result_value.Text = Convert.ToString(value / 1000);

            //km

            else if (current1 == "km" && current2 == "mm")
                result_value.Text = Convert.ToString(value * 1000000);

            else if (current1 == "km" && current2 == "cm")
                result_value.Text = Convert.ToString(value * 100000);

            else if (current1 == "km" && current2 == "dm")
                result_value.Text = Convert.ToString(value * 10000);

            else if (current1 == "km" && current2 == "m")
                result_value.Text = Convert.ToString(value * 1000);

            else if (current1 == "km" && current2 == "km")
                result_value.Text = Convert.ToString(value);

            //Gradian

            else if (current1 == "Gradian" && current2 == "Gradian")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "Gradian" && current2 == "Radian")
                result_value.Text = Convert.ToString(value * 0.0157);

            else if (current1 == "Gradian" && current2 == "Degree")
                result_value.Text = Convert.ToString(value * 0.9);

            //Radian

            else if (current1 == "Radian" && current2 == "Gradian")
                result_value.Text = Convert.ToString(value * 63.662);

            else if (current1 == "Radian" && current2 == "Radian")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "Radian" && current2 == "Degree")
                result_value.Text = Convert.ToString(value * 57.2958);

            //Degree

            else if (current1 == "Degree" && current2 == "Gradian")
                result_value.Text = Convert.ToString(value * 1.11);

            else if (current1 == "Degree" && current2 == "Radian")
                result_value.Text = Convert.ToString(value * (Math.PI/180));

            else if (current1 == "Degree" && current2 == "Degree")
                result_value.Text = Convert.ToString(value);

            //W

            else if (current1 == "W" && current2 == "W")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "W" && current2 == "kW")
                result_value.Text = Convert.ToString(value / 1000);

            else if (current1 == "W" && current2 == "Km")
                result_value.Text = Convert.ToString(value / 0.001357);

            //kW

            else if (current1 == "kW" && current2 == "W")
                result_value.Text = Convert.ToString(value * 1000);

            else if (current1 == "kW" && current2 == "kW")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "kW" && current2 == "Km")
                result_value.Text = Convert.ToString(value * 1.3596);

            //Km

            else if (current1 == "Km" && current2 == "W")
                result_value.Text = Convert.ToString(value * 735.4988);

            else if (current1 == "Km" && current2 == "kW")
                result_value.Text = Convert.ToString(value * 0.7355);

            else if (current1 == "Km" && current2 == "Km")
                result_value.Text = Convert.ToString(value);

            //cm3

            else if (current1 == "cm3" && current2 == "cm3")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "cm3" && current2 == "m3")
                result_value.Text = Convert.ToString(value * 0.000001);

            else if (current1 == "cm3" && current2 == "l")
                result_value.Text = Convert.ToString(value * 0.001);

            //m3

            else if (current1 == "m3" && current2 == "cm3")
                result_value.Text = Convert.ToString(value * 1000000);

            else if (current1 == "m3" && current2 == "m3")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "m3" && current2 == "l")
                result_value.Text = Convert.ToString(value * 1000);

            //l

            else if (current1 == "l" && current2 == "cm3")
                result_value.Text = Convert.ToString(value * 1000);

            else if (current1 == "l" && current2 == "m3")
                result_value.Text = Convert.ToString(value / 1000);

            else if (current1 == "l" && current2 == "l")
                result_value.Text = Convert.ToString(value);

            //mm2

            else if (current1 == "mm2" && current2 == "mm2")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "mm2" && current2 == "cm2")
                result_value.Text = Convert.ToString(value / 100);

            else if (current1 == "mm2" && current2 == "m2")
                result_value.Text = Convert.ToString(value / 1000000);

            else if (current1 == "mm2" && current2 == "km2")
                result_value.Text = Convert.ToString(value / 1000000000000);

            else if (current1 == "mm2" && current2 == "ha")
                result_value.Text = Convert.ToString(value / 10000000000);

            //cm2

            else if (current1 == "cm2" && current2 == "mm2")
                result_value.Text = Convert.ToString(value * 0.01);

            else if (current1 == "cm2" && current2 == "cm2")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "cm2" && current2 == "m2")
                result_value.Text = Convert.ToString(value * 10000);

            else if (current1 == "cm2" && current2 == "km2")
                result_value.Text = Convert.ToString(value * 100000000);

            else if (current1 == "cm2" && current2 == "ha")
                result_value.Text = Convert.ToString(value * 10000000000);

            //m2

            else if (current1 == "m2" && current2 == "mm2")
                result_value.Text = Convert.ToString(value * 0.0000001);

            else if (current1 == "m2" && current2 == "cm2")
                result_value.Text = Convert.ToString(value * 0.0001);

            else if (current1 == "m2" && current2 == "m2")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "m2" && current2 == "km2")
                result_value.Text = Convert.ToString(value * 1000000);

            else if (current1 == "m2" && current2 == "ha")
                result_value.Text = Convert.ToString(value * 1000);

            //km2

            else if (current1 == "km2" && current2 == "mm2")
                result_value.Text = Convert.ToString(value * 0.000000000001);

            else if (current1 == "km2" && current2 == "cm2")
                result_value.Text = Convert.ToString(value * 0.0000000001);

            else if (current1 == "km2" && current2 == "m2")
                result_value.Text = Convert.ToString(value * 0.000001);

            else if (current1 == "km2" && current2 == "km2")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "km2" && current2 == "ha")
                result_value.Text = Convert.ToString(value * 0.01);

            //ha

            else if (current1 == "ha" && current2 == "mm2")
                result_value.Text = Convert.ToString(value * 0.0000000001);

            else if (current1 == "ha" && current2 == "cm2")
                result_value.Text = Convert.ToString(value * 0.00000001);

            else if (current1 == "ha" && current2 == "m2")
                result_value.Text = Convert.ToString(value * 0.000001);

            else if (current1 == "ha" && current2 == "km2")
                result_value.Text = Convert.ToString(value * 100);

            else if (current1 == "ha" && current2 == "ha")
                result_value.Text = Convert.ToString(value);

            //cm/s

            else if (current1 == "cm/s" && current2 == "cm/s")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "cm/s" && current2 == "m/s")
                result_value.Text = Convert.ToString(value * 0.01);

            else if (current1 == "cm/s" && current2 == "km/h")
                result_value.Text = Convert.ToString(value * 0.036);

            else if (current1 == "cm/s" && current2 == "mp/h")
                result_value.Text = Convert.ToString(value * 0.022);

            //m/s

            else if (current1 == "m/s" && current2 == "cm/s")
                result_value.Text = Convert.ToString(value * 100);

            else if (current1 == "m/s" && current2 == "m/s")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "m/s" && current2 == "km/h")
                result_value.Text = Convert.ToString(value * 3.6);

            else if (current1 == "m/s" && current2 == "mp/h")
                result_value.Text = Convert.ToString(value * 2.24);

            //km/h

            else if (current1 == "km/h" && current2 == "cm/s")
                result_value.Text = Convert.ToString(value * 27.78);

            else if (current1 == "km/h" && current2 == "m/s")
                result_value.Text = Convert.ToString(value * 0.28);

            else if (current1 == "km/h" && current2 == "km/h")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "km/h" && current2 == "mp/h")
                result_value.Text = Convert.ToString(value * 0.62);

            //mp/h

            else if (current1 == "km/h" && current2 == "cm/s")
                result_value.Text = Convert.ToString(value * 44.704);

            else if (current1 == "km/h" && current2 == "m/s")
                result_value.Text = Convert.ToString(value * 0.45);

            else if (current1 == "km/h" && current2 == "km/h")
                result_value.Text = Convert.ToString(value * 1.61);

            else if (current1 == "km/h" && current2 == "mp/h")
                result_value.Text = Convert.ToString(value);

            //Kelvin

            else if (current1 == "Kelvin" && current2 == "Kelvin")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "Kelvin" && current2 == "Celsius")
                result_value.Text = Convert.ToString(value - 272.15);

            else if (current1 == "Kelvin" && current2 == "Fahrenheit")
                result_value.Text = Convert.ToString(value - 457.87);

            //Celsius

            else if (current1 == "Celsius" && current2 == "Kelvin")
                result_value.Text = Convert.ToString(value + 272.15);

            else if (current1 == "Celsius" && current2 == "Celsius")
                result_value.Text = Convert.ToString(value);

            else if (current1 == "Celsius" && current2 == "Fahrenheit")
                result_value.Text = Convert.ToString((value * 1.8) + 32);

            //Fahrenheit

            else if (current1 == "Fahrenheit" && current2 == "Kelvin")
                result_value.Text = Convert.ToString(value + 272.15);

            else if (current1 == "Fahrenheit" && current2 == "Celsius")
                result_value.Text = Convert.ToString((value - 32) / 1.8);

            else if (current1 == "Fahrenheit" && current2 == "Fahrenheit")
                result_value.Text = Convert.ToString(value);

                    unitIn.Enabled = false;
                    unitOut.Enabled = false;
                    button_calculate.Enabled = false;
                    calculateLight.BackColor = Color.Red;
        }
        //Reset - Button
        private void button_reset_Click(object sender, EventArgs e)
        {
            unitIn.Items.Clear();
            unitOut.Items.Clear();
            unitIn.Text = null;
            unitOut.Text = null;
            calculateLight.BackColor = Color.Red;

            unitType.SelectedItem = 0;

            unitIn.Enabled = false;
            unitOut.Enabled = false;
            unitIn_value.Text = null;
            result_value.Text = null;
            unitType.SelectedIndex = 0;
        }

        private void unitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string current = unitType.SelectedItem.ToString();
            button_calculate.Enabled = true;

            switch (current)
                    {
                        //Weight - UnitType
                        case "Weight": 

                            unitIn.Enabled = true;
                            unitIn.Items.Clear();
                            unitIn.Items.AddRange(new object[] { "<Select>", "g", "dag", "kg", "t" });

                            unitOut.Enabled = true;
                            unitOut.Items.Clear();
                            unitOut.Items.AddRange(new object[] { "<Select>", "g", "dag", "kg", "t" });

                            unitIn.SelectedIndex = 0;
                            unitOut.SelectedIndex = 0;
                            break;

                        //Time - UnitType
                        case "Time":
                            unitIn.Enabled = true;
                            unitIn.Items.Clear();
                            unitIn.Items.AddRange(new object[] { "<Select>", "Milliseconds", "Seconds", "Minutes", "Hours" });

                            unitOut.Enabled = true;
                            unitOut.Items.Clear();
                            unitOut.Items.AddRange(new object[] { "<Select>", "Milliseconds", "Seconds", "Minutes", "Hours" });

                            unitIn.SelectedIndex = 0;
                            unitOut.SelectedIndex = 0;
                            break;

                        //Length - UnitType
                        case "Length":                                                                     
                            unitIn.Enabled = true;
                            unitIn.Items.Clear();
                            unitIn.Items.AddRange(new object[] { "<Select>", "mm", "cm", "dm", "m", "km" });

                            unitOut.Enabled = true;
                            unitOut.Items.Clear();
                            unitOut.Items.AddRange(new object[] { "<Select>", "mm", "cm", "dm", "m", "km" });

                            unitIn.SelectedIndex = 0;
                            unitOut.SelectedIndex = 0;
                            break;

                       //Angle - UnitType
                        case "Angle":                  
                            unitIn.Enabled = true;
                            unitIn.Items.Clear();
                            unitIn.Items.AddRange(new object[] { "<Select>", "Gradian", "Radian", "Degree" });

                            unitOut.Enabled = true;
                            unitOut.Items.Clear();
                            unitOut.Items.AddRange(new object[] { "<Select>", "Gradian", "Radian", "Degree" });

                            unitIn.SelectedIndex = 0;
                            unitOut.SelectedIndex = 0;
                            break;

                        //Power - UnitType
                        case "Power":
                            unitIn.Enabled = true;
                            unitIn.Items.Clear();
                            unitIn.Items.AddRange(new object[] { "<Select>", "W", "kW", "Km" });

                            unitOut.Enabled = true;
                            unitOut.Items.Clear();
                            unitOut.Items.AddRange(new object[] { "<Select>", "W", "kW", "Km" });

                            unitIn.SelectedIndex = 0;
                            unitOut.SelectedIndex = 0;
                            break;

                        //Volume - UnitType
                        case "Volume":
                            unitIn.Enabled = true;
                            unitIn.Items.Clear();
                            unitIn.Items.AddRange(new object[] { "<Select>", "cm3", "m3", "l" });

                            unitOut.Enabled = true;
                            unitOut.Items.Clear();
                            unitOut.Items.AddRange(new object[] { "<Select>", "cm3", "m3", "l" });

                            unitIn.SelectedIndex = 0;
                            unitOut.SelectedIndex = 0;
                            break;

                        //Area - UnitType
                        case "Area":
                            unitIn.Enabled = true;
                            unitIn.Items.Clear();
                            unitIn.Items.AddRange(new object[] { "<Select>", "mm2", "cm2", "m2", "km2", "ha" });

                            unitOut.Enabled = true;
                            unitOut.Items.Clear();
                            unitOut.Items.AddRange(new object[] { "<Select>", "mm2", "cm2", "m2", "km2", "ha" });

                            unitIn.SelectedIndex = 0;
                            unitOut.SelectedIndex = 0;
                            break;

                        //Speed - UnitType
                        case "Speed":
                            unitIn.Enabled = true;
                            unitIn.Items.Clear();
                            unitIn.Items.AddRange(new object[] { "<Select>", "cm/s", "m/s", "km/h", "mp/h" });

                            unitOut.Enabled = true;
                            unitOut.Items.Clear();
                            unitOut.Items.AddRange(new object[] { "<Select>", "cm/s", "m/s", "km/h", "mp/h" });

                            unitIn.SelectedIndex = 0;
                            unitOut.SelectedIndex = 0;
                            break;

                        //Temperature - UnitType
                        case "Temperature":
                            unitIn.Enabled = true;
                            unitIn.Items.Clear();
                            unitIn.Items.AddRange(new object[] { "<Select>", "Kelvin", "Celsius", "Fahrenheit" });

                            unitOut.Enabled = true;
                            unitOut.Items.Clear();
                            unitOut.Items.AddRange(new object[] { "<Select>", "Kelvin", "Celsius", "Fahrenheit" });

                            unitIn.SelectedIndex = 0;
                            unitOut.SelectedIndex = 0;
                            break;

                        //Default - UnitType
                        case "<Select>":
                            unitIn.Items.Clear();
                            unitOut.Items.Clear();
                            button_calculate.Enabled = false;
                            unitIn.Enabled = false;
                            unitOut.Enabled = false;
                            unitIn_value.Text = "0";
                    break;
                    }
            }

        //Calculate - Button - Backlight control
        private void calculateBacklight_Tick(object sender, EventArgs e)
        {
            if (unitIn.Enabled == false || unitOut.Enabled == false)
                calculateLight.BackColor = Color.Red;
            else
            {
                string current1 = unitIn.SelectedItem.ToString();
                string current2 = unitOut.SelectedItem.ToString();

                if (current1 == "<Select>" || current2 == "<Select>")
                    calculateLight.BackColor = Color.Red;
                else
                    calculateLight.BackColor = Color.Green;
            }              
        }
    }
    }