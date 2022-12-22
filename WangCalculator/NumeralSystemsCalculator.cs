using System;
using System.Drawing;
using System.Windows.Forms;

namespace WangCalculator
{
    public partial class NumeralSystemsCalculator : Form
    {
        //Expression input state
        bool enterValue = false;

        //Counting the number of clicks - KeyboardButton
        int keyboardButton_counter = 0;

        public NumeralSystemsCalculator()
        {
            InitializeComponent();                                                                          
            unitType.SelectedIndex = 0;
        }

        //Numeric values handling
        private void numbers_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            //Start value (zero) handling.
            if ((unitIn_value.Text == "0") || (enterValue))
                unitIn_value.Text = "";
            enterValue = false;

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
            calculateLight.BackColor = Color.Green;
            if (unitIn_value.Text.Length > 1)
                unitIn_value.Text = unitIn_value.Text.Remove(unitIn_value.Text.Length - 1, 1);
            else
                unitIn_value.Text = "0";
        }

        //Calculate - Button
        private void button_calculate_Click(object sender, EventArgs e)
        {
            string current = unitType.SelectedItem.ToString();
            calculateLight.BackColor = Color.Red;

            //Decimal system - operations
            if (current == "DEC") 
            {
                int value = int.Parse(unitIn_value.Text);
                decValue.Text = unitIn_value.Text;
                binValue.Text = Convert.ToString(value, 2);
                octValue.Text = Convert.ToString(value, 8);
                hexValue.Text = Convert.ToString(value, 16);
            }

            //Binary system - operations
            else if (current == "BIN") 
            {
                binValue.Text = unitIn_value.Text;
                int value = Convert.ToInt32(unitIn_value.Text, 2);
                decValue.Text = Convert.ToString(value);
                octValue.Text = Convert.ToString(value, 8);
                hexValue.Text = Convert.ToString(value, 16);
            }

            //Octal system.  - operations
            else if (current == "OCT")
            {
                octValue.Text = unitIn_value.Text;
                int value = Convert.ToInt32(unitIn_value.Text, 8);
                decValue.Text = Convert.ToString(value);
                binValue.Text = Convert.ToString(value, 2);
                hexValue.Text = Convert.ToString(value, 16);
            }

            //Hexadecimal system  - operations
            else if (current == "HEX")
            {
                hexValue.Text = unitIn_value.Text;
                int value = Convert.ToInt32(unitIn_value.Text, 16);
                decValue.Text = Convert.ToString(value);
                octValue.Text = Convert.ToString(value, 8);
                binValue.Text = Convert.ToString(value, 2);
            }
        }

        //Reset - Button
        private void button_reset_Click(object sender, EventArgs e)
        {
            calculateLight.BackColor = Color.Red;

            binValue.Text = "";
            decValue.Text = "";
            octValue.Text = "";
            hexValue.Text = "";

            unitType.SelectedIndex = 0;
            unitIn_value.Text = Convert.ToString("0");
            unitIn_value.Enabled = false;
            button_calculate.Enabled = false;
            unitType.SelectedIndex = 0;
            unitIn_value.Text = "0";
        }

        private void unitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string current = unitType.SelectedItem.ToString();
            button_calculate.Enabled = true;

                    switch (current)
                    {
                        //Key configuration for the decimal system
                        case "DEC":
                            binValue.Text = "";
                            decValue.Text = "";
                            octValue.Text = "";
                            hexValue.Text = "";
                            unitIn_value.Text = "0";
                            button_0.Enabled = true;
                            button_1.Enabled = true;
                            button_2.Enabled = true;
                            button_3.Enabled = true;
                            button_4.Enabled = true;
                            button_5.Enabled = true;
                            button_6.Enabled = true;
                            button_7.Enabled = true;
                            button_8.Enabled = true;
                            button_9.Enabled = true;
                            button_A.Enabled = false;
                            button_B.Enabled = false;
                            button_C.Enabled = false;
                            button_D.Enabled = false;
                            button_E.Enabled = false;
                            button_F.Enabled = false;
                            button_2.Visible = true;
                            button_3.Visible = true;
                            button_4.Visible = true;
                            button_5.Visible = true;
                            button_6.Visible = true;
                            button_7.Visible = true;
                            button_8.Visible = true;
                            button_9.Visible = true;
                            button_A.Visible = false;
                            button_B.Visible = false;
                            button_C.Visible = false;
                            button_D.Visible = false;
                            button_E.Visible = false;
                            button_F.Visible = false;
                            button_backspace.Visible = true;
                            button_backspace.Enabled = true;
                            unitIn_value.Enabled = true;
                            calculateLight.BackColor = Color.Green;
                            break;

                        //Key configuration for a binary system
                        case "BIN":
                            binValue.Text = "";
                            decValue.Text = "";
                            octValue.Text = "";
                            hexValue.Text = "";
                            unitIn_value.Text = "0";
                            button_0.Enabled = true;
                            button_1.Enabled = true;
                            button_2.Enabled = false;
                            button_3.Enabled = false;
                            button_4.Enabled = false;
                            button_5.Enabled = false;
                            button_6.Enabled = false;
                            button_7.Enabled = false;
                            button_8.Enabled = false;
                            button_9.Enabled = false;
                            button_A.Enabled = false;
                            button_B.Enabled = false;
                            button_C.Enabled = false;
                            button_D.Enabled = false;
                            button_E.Enabled = false;
                            button_F.Enabled = false;
                            button_2.Visible = false;
                            button_3.Visible = false;
                            button_4.Visible = false;
                            button_5.Visible = false;
                            button_6.Visible = false;
                            button_7.Visible = false;
                            button_8.Visible = false;
                            button_9.Visible = false;
                            button_A.Visible = false;
                            button_B.Visible = false;
                            button_C.Visible = false;
                            button_D.Visible = false;
                            button_E.Visible = false;
                            button_F.Visible = false;
                            button_backspace.Visible = true;
                            button_backspace.Enabled = true;
                            unitIn_value.Enabled = true;
                            calculateLight.BackColor = Color.Green;
                            break;

                        //Key configuration for the octal system.
                        case "OCT":
                            binValue.Text = "";
                            decValue.Text = "";
                            octValue.Text = "";
                            hexValue.Text = "";
                            unitIn_value.Text = "0";
                            button_0.Enabled = true;
                            button_1.Enabled = true;
                            button_2.Enabled = true;
                            button_3.Enabled = true;
                            button_4.Enabled = true;
                            button_5.Enabled = true;
                            button_6.Enabled = true;
                            button_7.Enabled = true;
                            button_8.Enabled = false;
                            button_9.Enabled = false;
                            button_A.Enabled = false;
                            button_B.Enabled = false;
                            button_C.Enabled = false;
                            button_D.Enabled = false;
                            button_E.Enabled = false;
                            button_F.Enabled = false;
                            button_2.Visible = true;
                            button_3.Visible = true;
                            button_4.Visible = true;
                            button_5.Visible = true;
                            button_6.Visible = true;
                            button_7.Visible = true;
                            button_8.Visible = false;
                            button_9.Visible = false;
                            button_A.Visible = false;
                            button_B.Visible = false;
                            button_C.Visible = false;
                            button_D.Visible = false;
                            button_E.Visible = false;
                            button_F.Visible = false;
                            button_backspace.Visible = true;
                            button_backspace.Enabled = true;
                            unitIn_value.Enabled = true;
                            calculateLight.BackColor = Color.Green;
                            break;

                        //Key configuration for hexadecimal system
                        case "HEX":
                            binValue.Text = "";
                            decValue.Text = "";
                            octValue.Text = "";
                            hexValue.Text = "";
                            unitIn_value.Text = "0";
                            button_0.Enabled = true;
                            button_1.Enabled = true;
                            button_2.Enabled = true;
                            button_3.Enabled = true;
                            button_4.Enabled = true;
                            button_5.Enabled = true;
                            button_6.Enabled = true;
                            button_7.Enabled = true;
                            button_8.Enabled = true;
                            button_9.Enabled = true;
                            button_A.Enabled = true;
                            button_B.Enabled = true;
                            button_C.Enabled = true;
                            button_D.Enabled = true;
                            button_E.Enabled = true;
                            button_F.Enabled = true;
                            button_2.Visible = true;
                            button_3.Visible = true;
                            button_4.Visible = true;
                            button_5.Visible = true;
                            button_6.Visible = true;
                            button_7.Visible = true;
                            button_8.Visible = true;
                            button_9.Visible = true;
                            button_A.Visible = true;
                            button_B.Visible = true;
                            button_C.Visible = true;
                            button_D.Visible = true;
                            button_E.Visible = true;
                            button_F.Visible = true;
                            button_backspace.Visible = true;
                            button_backspace.Enabled = true;
                            unitIn_value.Enabled = true;
                            calculateLight.BackColor = Color.Green;
                            break;

                        //Default key configuration
                        case "<Select>":
                            binValue.Text = "";
                            decValue.Text = "";
                            octValue.Text = "";
                            hexValue.Text = "";
                            unitIn_value.Text = "0";
                            button_0.Enabled = false;
                            button_1.Enabled = false;
                            button_2.Enabled = false;
                            button_3.Enabled = false;
                            button_4.Enabled = false;
                            button_5.Enabled = false;
                            button_6.Enabled = false;
                            button_7.Enabled = false;
                            button_8.Enabled = false;
                            button_9.Enabled = false;
                            button_A.Enabled = false;
                            button_B.Enabled = false;
                            button_C.Enabled = false;
                            button_D.Enabled = false;
                            button_E.Enabled = false;
                            button_F.Enabled = false;
                            button_2.Visible = true;
                            button_3.Visible = true;
                            button_4.Visible = true;
                            button_5.Visible = true;
                            button_6.Visible = true;
                            button_7.Visible = true;
                            button_8.Visible = true;
                            button_9.Visible = true;
                            button_A.Visible = true;
                            button_B.Visible = true;
                            button_C.Visible = true;
                            button_D.Visible = true;
                            button_E.Visible = true;
                            button_F.Visible = true;
                            button_backspace.Visible = true;
                            button_backspace.Enabled = false;
                            unitIn_value.Enabled = false;
                            calculateLight.BackColor = Color.Red;
                            break;
            }
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
    }
}
