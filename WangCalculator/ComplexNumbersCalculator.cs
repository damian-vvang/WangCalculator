using System;
using System.Drawing;
using System.Windows.Forms;
using System.Numerics;

namespace WangCalculator
{
    public partial class ComplexNumbersCalculator : Form
    {
        bool enter_value = false;         //Expression input state
        int keyboardButton_counter = 0;   //Counting the number of clicks on a button - [keyboard]
        int activeField_counter = 0;      //Counting the number of clicks on a button - [Switch - active field]
        int current = 0;                  //Index of current selection - [Switch - active field]
        string operation = "";            //Content of current operation
        double plusORminus;               //Plus or minus - the current state.

        //Temporary values - switches - backlight sequence of the elements.
        private int realUnit1_SW, realUnit2_SW, imgUnit1_SW, imgUnit2_SW, selectionSW = 0;

        public ComplexNumbersCalculator()
        {
            InitializeComponent();

            //Initial state
            current = 1;
            button_calculate.Enabled = false;
            realUnit1_Timer.Start();
            selectionTimer.Start();
        }

        //Keyboard - button
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

        //Switch - button [Switching between active fields]
        private void button_switch_Click(object sender, EventArgs e)
        {
            ++activeField_counter;
            switch (current)
            {
                case 1:
                    realUnit1_Timer.Stop();
                    imgUnit1_Timer.Start();
                    current = 2;
                    realUnit1.BackColor = Color.Black;
                    break;

                case 2:
                    imgUnit1_Timer.Stop();
                    realUnit2_Timer.Start();
                    current = 3;
                    imgUnit1.BackColor = Color.Black;
                    break;

                case 3:
                    realUnit2_Timer.Stop();
                    imgUnit2_Timer.Start();
                    current = 4;
                    realUnit2.BackColor = Color.Black;
                    break;

                case 4:
                    imgUnit2_Timer.Stop();
                    realUnit1_Timer.Start();
                    activeField_counter = 1;
                    current = 1;
                    imgUnit2.BackColor = Color.Black;
                    imgUnit2.BackColor = Color.Black;
                    break;
            }
        }

        //Reset - button [Restore to initial state]
        private void button_reset_Click(object sender, EventArgs e)
        {
            realUnit1_Timer.Start();
            imgUnit1_Timer.Stop();
            realUnit2_Timer.Stop();
            imgUnit2_Timer.Stop();

            activeField_counter = 1;
            current = 1;

            realUnit1.Text = Convert.ToString(0);
            imgUnit1.Text = Convert.ToString(0);
            realUnit2.Text = Convert.ToString(0);
            imgUnit2.Text = Convert.ToString(0);
            result_realUnit.Text = Convert.ToString(0);
            result_imgUnit.Text = Convert.ToString(0);

            realUnit1.BackColor = Color.Black;
            imgUnit1.BackColor = Color.Black;
            realUnit2.BackColor = Color.Black;
            imgUnit2.BackColor = Color.Black;
            additionLight.BackColor = Color.Black;
            subtractionLight.BackColor = Color.Black;
            multiplicationLight.BackColor = Color.Black;
            divisionLight.BackColor = Color.Black;
            calculateLight.BackColor = Color.Red;

            button_addition.Enabled = true;
            button_subtraction.Enabled = true;
            button_multiplication.Enabled = true;
            button_division.Enabled = true;
            button_calculate.Enabled = false;
            operation = "";
        }

        //Backspace button - delete the last character.
        private void button_backspace_Click(object sender, EventArgs e)
        {
            switch (current)
            {
                case 1:
                    if (realUnit1.Text.Length > 1)
                        realUnit1.Text = realUnit1.Text.Remove(realUnit1.Text.Length - 1, 1);
                    else
                        realUnit1.Text = "0";
                    break;

                case 2:
                    if (imgUnit1.Text.Length > 1)
                        imgUnit1.Text = imgUnit1.Text.Remove(imgUnit1.Text.Length - 1, 1);
                    else
                        imgUnit1.Text = "0";
                    break;

                case 3:
                    if (realUnit2.Text.Length > 1)
                        realUnit2.Text = realUnit2.Text.Remove(realUnit2.Text.Length - 1, 1);
                    else
                        realUnit2.Text = "0";
                    break;

                case 4:
                    if (imgUnit2.Text.Length > 1)
                        imgUnit2.Text = imgUnit2.Text.Remove(imgUnit2.Text.Length - 1, 1);
                    else
                        imgUnit2.Text = "0";
                    break;
            }
        }

        //"+/-" - sign inversion - button.
        private void button_plus_or_minus_Click(object sender, EventArgs e)
        {
            switch (current)
            {
                case 1:
                    plusORminus = Double.Parse(realUnit1.Text);
                    plusORminus = Convert.ToDouble(realUnit1.Text) * Convert.ToDouble(-1);
                    realUnit1.Text = Convert.ToString(plusORminus);
                    break;
                case 2:
                    plusORminus = Double.Parse(imgUnit1.Text);
                    plusORminus = Convert.ToDouble(imgUnit1.Text) * Convert.ToDouble(-1);
                    imgUnit1.Text = Convert.ToString(plusORminus);
                    break;
                case 3:
                    plusORminus = Double.Parse(realUnit2.Text);
                    plusORminus = Convert.ToDouble(realUnit2.Text) * Convert.ToDouble(-1);
                    realUnit2.Text = Convert.ToString(plusORminus);
                    break;
                case 4:
                    plusORminus = Double.Parse(imgUnit2.Text);
                    plusORminus = Convert.ToDouble(imgUnit2.Text) * Convert.ToDouble(-1);
                    imgUnit2.Text = Convert.ToString(plusORminus);
                    break;
            }
        }

        //Numeric values buttons group.
        private void numbers_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (current)
            {
                //realUnit1 - field
                case 1:

                    //Start value (zero) handling.
                    if ((realUnit1.Text == "0") || (enter_value))
                    {
                        realUnit1.Text = "";
                        enter_value = false;
                    }

                    //Decimal part handling - DOT character
                    if (button.Text == ".")
                    {
                        if (!realUnit1.Text.Contains("."))
                            realUnit1.Text = realUnit1.Text + button.Text;
                    }
                    else
                        realUnit1.Text = realUnit1.Text + button.Text;
                    break;

                //imgUnit1 - field
                case 2:

                    //Start value (zero) handling.
                    if ((imgUnit1.Text == "0") || (enter_value))
                    {
                        imgUnit1.Text = "";
                        enter_value = false;
                    }

                    //Decimal part handling - DOT character
                    if (button.Text == ".")
                    {
                        if (!imgUnit1.Text.Contains("."))
                            imgUnit1.Text = imgUnit1.Text + button.Text;
                    }
                    else
                        imgUnit1.Text = imgUnit1.Text + button.Text;
                    break;

                //realUnit2 - field
                case 3:

                    //Start value (zero) handling.
                    if ((realUnit2.Text == "0") || (enter_value))
                    {
                        realUnit2.Text = "";
                        enter_value = false;
                    }

                    //Decimal part handling - DOT character
                    if (button.Text == ".")
                    {
                        if (!realUnit2.Text.Contains("."))
                            realUnit2.Text = realUnit2.Text + button.Text;
                    }
                    else
                        realUnit2.Text = realUnit2.Text + button.Text;
                    break;

                //imgUnit2 - field
                case 4:

                    //Start value (zero) handling.
                    if ((imgUnit2.Text == "0") || (enter_value))
                    {
                        imgUnit2.Text = "";
                        enter_value = false;
                    }

                    //Decimal part handling - DOT character
                    if (button.Text == ".")
                    {
                        if (!imgUnit2.Text.Contains("."))
                            imgUnit2.Text = imgUnit2.Text + button.Text;
                    }
                    else
                        imgUnit2.Text = imgUnit2.Text + button.Text;
                    break;
            }
        }

        //Addition - button
        private void button_addition_Click(object sender, EventArgs e)
        {
            calculateLight.BackColor = Color.Green;
            additionLight.BackColor = Color.Green;
            subtractionLight.BackColor = Color.Black;
            multiplicationLight.BackColor = Color.Black;
            divisionLight.BackColor = Color.Black;
            button_calculate.Enabled = true;
            operation = "addition";
        }

        //Subtraction - button
        private void button_subtraction_Click(object sender, EventArgs e)
        {
            calculateLight.BackColor = Color.Green;
            additionLight.BackColor = Color.Black;
            subtractionLight.BackColor = Color.Green;
            multiplicationLight.BackColor = Color.Black;
            divisionLight.BackColor = Color.Black;
            button_calculate.Enabled = true;
            operation = "subtraction";

        }

        //Multiplication - button
        private void button_multiplication_Click(object sender, EventArgs e)
        {
            calculateLight.BackColor = Color.Green;
            additionLight.BackColor = Color.Black;
            subtractionLight.BackColor = Color.Black;
            multiplicationLight.BackColor = Color.Green;
            divisionLight.BackColor = Color.Black;
            button_calculate.Enabled = true;
            operation = "multiplication";
        }

        //Divistion - button
        private void button_division_Click(object sender, EventArgs e)
        {
            calculateLight.BackColor = Color.Green;
            additionLight.BackColor = Color.Black;
            subtractionLight.BackColor = Color.Black;
            multiplicationLight.BackColor = Color.Black;
            divisionLight.BackColor = Color.Green;
            button_calculate.Enabled = true;
            operation = "division";
        }

        //Calculate - button
        private void button_calculate_Click(object sender, EventArgs e)
        {
            double real1 = Convert.ToDouble(realUnit1.Text);
            double real2 = Convert.ToDouble(realUnit2.Text);
            double img1 = Convert.ToDouble(imgUnit1.Text);
            double img2 = Convert.ToDouble(imgUnit2.Text);
            calculateLight.BackColor = Color.Red;

            if (operation == "addition")
            {
                button_calculate.Enabled = false;

                Complex a1 = new Complex(real1, img1);
                Complex a2 = new Complex(real2, img2);
                Complex a3 = a1 + a2;

                result_realUnit.Text = Convert.ToString(a3.Real);
                result_imgUnit.Text = Convert.ToString(a3.Imaginary);
            }
            else if (operation == "subtraction")
            {
                button_calculate.Enabled = false;

                Complex a1 = new Complex(real1, img1);
                Complex a2 = new Complex(real2, img2);
                Complex a3 = a1 - a2;

                result_realUnit.Text = Convert.ToString(a3.Real);
                result_imgUnit.Text = Convert.ToString(a3.Imaginary);

            }
            else if (operation == "multiplication")
            {
                button_calculate.Enabled = false;

                Complex a1 = new Complex(real1, img1);
                Complex a2 = new Complex(real2, img2);
                Complex a3 = a1 * a2;

                result_realUnit.Text = Convert.ToString(a3.Real);
                result_imgUnit.Text = Convert.ToString(a3.Imaginary);
            }
            else if (operation == "division")
            {
                button_calculate.Enabled = false;

                Complex a1 = new Complex(real1, img1);
                Complex a2 = new Complex(real2, img2);
                Complex a3 = a1 / a2;

                result_realUnit.Text = Convert.ToString(a3.Real);
                result_imgUnit.Text = Convert.ToString(a3.Imaginary);
            }
        }

        //Timer - imgUnit2 field - backlight control.
        private void imgUnit2_Timer_Tick(object sender, EventArgs e)
        {
            imgUnit2_SW++;
            switch (imgUnit2_SW)
            {
                case 1:
                    imgUnit2.BackColor = Color.Blue;
                    break;
                case 2:
                    imgUnit2.BackColor = Color.Black;
                    break;
            }
            if (imgUnit2_SW == 2) imgUnit2_SW = 0;
        }

        //Timer - realUnit2 field - backlight control.
        private void realUnit2_Timer_Tick(object sender, EventArgs e)
        {
            realUnit2_SW++;
            switch (realUnit2_SW)
            {
                case 1:
                    realUnit2.BackColor = Color.Blue;
                    break;
                case 2:
                    realUnit2.BackColor = Color.Black;
                    break;
            }
            if (realUnit2_SW == 2) realUnit2_SW = 0;
        }

        //Timer - imgUnit1 field - backlight control.
        private void imgUnit1_Timer_Tick(object sender, EventArgs e)
        {
            imgUnit1_SW++;
            switch (imgUnit1_SW)
            {
                case 1:
                    imgUnit1.BackColor = Color.Blue;
                    break;
                case 2:
                    imgUnit1.BackColor = Color.Black;
                    break;
            }
            if (imgUnit1_SW == 2) imgUnit1_SW = 0;
        }

        //Timer - realUnit1 field - backlight control.
        private void realUnit1_Timer_Tick(object sender, EventArgs e)
        {
            realUnit1_SW++;
            switch (realUnit1_SW)
            {
                case 1:
                    realUnit1.BackColor = Color.Blue;
                    break;
                case 2:
                    realUnit1.BackColor = Color.Black;
                    break;
            }
            if (realUnit1_SW == 2) realUnit1_SW = 0;
        }

        //Timer - selection button - backlight control.
        private void selectionTimer_Tick(object sender, EventArgs e)
        {
            selectionSW++;
            switch (selectionSW)
            {
                case 1:
                    selectionBacklight.Visible = true;
                    break;
                case 2:
                    selectionBacklight.Visible = false;
                    break;
            }
            if (selectionSW == 2) selectionSW = 0;
        }
    }
}
