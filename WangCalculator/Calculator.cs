using System;
using System.Windows.Forms;

namespace WangCalculator
{
    public partial class Calculator : Form
    {
        String operation = "";      //Content of current operation
        bool enter_value = false;   //Expression input state
        string temp1, temp2;        //The last two expressions for the history view
        int NumberOfClickX1Y = 0;   //Counting the number of clicks on a button - [x_to_the_power_of_1_slash_y]
        int NumberOfClickH = 0;     //Counting the number of clicks on a button - [history]
        int NumberOfClickXY = 0;    //Counting the number of clicks on a button - [x_to_the_power_of_y]
        double x1, y1, result = 0;  //Temporary variables - [x_to_the_power_of_y], [x_to_the_power_of_1_slash_y] and [result]
        double memory;              //Calculator cache - [MC,MR,MS,M+,M-]

        public Calculator()
        {
            InitializeComponent();
            this.Width = 611;

            //Restriction related to the supported resolution.
            int screenHeight = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height.ToString());
            
                if (screenHeight < 1080)
            {
                MessageBox.Show("The height parameter for your resolution must be greater than or equal to 1080 pixels.", "Error, your screen resolution is not supported!");
                throw new ArgumentException();
            }
        }

        //"OPTN" - option - button.
        private void button_OPTN_Click(object sender, EventArgs e) 
        {
            Options options = new Options();
            options.ShowDialog();
        }

        //"History" - button - displaying the history of entered expressions.
        private void button_history_Click(object sender, EventArgs e)
        {  
            ++NumberOfClickH;
            switch(NumberOfClickH)
            {
                case 1:
                    this.Width = 1214;
                    break;
                case 2:
                    this.Width = 611;
                    NumberOfClickH = 0;
                    break;
            }    
        }

        //"Clear" - button - clearing the history of entered actions.
        private void button_clear_Click(object sender, EventArgs e)
        {
            lcdHistory.Text = " ";
        }

        //Numeric values buttons group.
        private void numbers_Click(object sender, EventArgs e) 
        {
            Button button = (Button)sender;

            //Start value (zero) handling.
            if ((lcdResult.Text == "0") || (enter_value))
                lcdResult.Text = "";
                enter_value = false;

            //Decimal part handling - DOT character.
            if (button.Text == ".")
            {
                if (!lcdResult.Text.Contains("."))
                    lcdResult.Text = lcdResult.Text + button.Text; 
            }
            else
            {
                lcdResult.Text = lcdResult.Text + button.Text;
            }
        }

        //"." - Dot button.
        private void button_dot_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            //Decimal part handling - COMMA character.
            if (button.Text == ",")
            {
                if (!lcdResult.Text.Contains(","))
                    lcdResult.Text = lcdResult.Text + button.Text;
            }
            else
            {
                lcdResult.Text = lcdResult.Text + button.Text;
            }
        }

        // Arithmetic operation buttons group.
        private void operators_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                button_result.PerformClick();
                enter_value = true;
                operation = button.Text;
                lcdSecond.Text = result + " " + operation;
            }
            else
            {
                operation = button.Text;
                try 
                {
                    result = Double.Parse(lcdResult.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("An unknown error occurred!");
                    Application.Exit();
                }
                enter_value = true;
                lcdSecond.Text = result + " " + operation;
            }

            temp1 = lcdSecond.Text;
        }

        //"C" - Clear button - all input.
        private void button_C_Click(object sender, EventArgs e)
        {
            lcdResult.Text = "0";
            lcdSecond.Text = "";
            result = 0;
        }

        //"CE" - Clear button - recent entry.
        private void button_CE_Click(object sender, EventArgs e)
        {
            lcdResult.Text = "0";
        }

        //"=" - Result button.
        private void button_result_Click(object sender, EventArgs e)
        {
            temp2 = lcdResult.Text;

            lcdSecond.Text = "";
            switch (operation)
            {
                case "+":
                    lcdResult.Text = (result + Double.Parse(lcdResult.Text)).ToString();
                    break;
                case "-":
                    lcdResult.Text = (result - Double.Parse(lcdResult.Text)).ToString();
                    break;
                case "*":
                    lcdResult.Text = (result * Double.Parse(lcdResult.Text)).ToString();
                    break;
                case "/":
                    lcdResult.Text = (result / Double.Parse(lcdResult.Text)).ToString();
                    break;
                case "Mod":
                    lcdResult.Text = (result % Double.Parse(lcdResult.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(lcdResult.Text);
                    double q;
                    q = (result);
                    lcdResult.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
                default:
                    break;
            }
            try
            {
                result = Double.Parse(lcdResult.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("An unknown error occurred!");
                Application.Exit();
            }
            operation = "";

            if (temp2 != lcdResult.Text)
            {
                lcdHistory.AppendText(temp1 + " " + temp2 + "  =  " + "");
                lcdHistory.AppendText(" " + lcdResult.Text + Environment.NewLine);
            }
        }

        //"π" - Pi button.
        private void button_pi_Click(object sender, EventArgs e)                                
        {
            double pi = Math.PI;
            lcdResult.Text = pi.ToString();
            lcdHistory.AppendText("π" + " = ");
            lcdSecond.Text = Convert.ToString("π");
            lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);
        }

        //"2π" - 2Pi button.
        private void button_2pi_Click(object sender, EventArgs e)
        {
            double pi = 2*(Math.PI);
            lcdResult.Text = pi.ToString();
            lcdHistory.AppendText("2π" + " = ");
            lcdSecond.Text = Convert.ToString("2π");
            lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);
        }

        //"log" - button.
        private void button_log_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(lcdResult.Text);
            lcdSecond.Text = Convert.ToString("log" + "(" + (lcdResult.Text) + ")");
            lcdHistory.AppendText("log(" + log + ")  =  " + "");
            log = Math.Log10(log);
            lcdResult.Text = Convert.ToString(log);
            lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);

        }

        //"1/x" - button.
        private void button_1_slash_x_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(lcdResult.Text);
            lcdSecond.Text = Convert.ToString("1/(" + (lcdResult.Text) + ")");
            lcdHistory.AppendText("1 / (" + x + ") = ");
            x = Convert.ToDouble(1.0 / Convert.ToDouble(lcdResult.Text));
            lcdResult.Text = Convert.ToString(x);
            lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);

        }

        //"%" - percent button.
        private void button_percent_Click(object sender, EventArgs e)
        {
            double percent = Double.Parse(lcdResult.Text);
            lcdSecond.Text = Convert.ToString((lcdResult.Text) + "%");
            lcdHistory.AppendText(percent + "%" + " = ");
            percent = Convert.ToDouble(lcdResult.Text) / (Convert.ToDouble(100));
            lcdResult.Text = Convert.ToString(percent);
            lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);
        }

        //"√" - sqrt button.
        private void button_sqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Double.Parse(lcdResult.Text);
            lcdSecond.Text = Convert.ToString("√" + (lcdResult.Text));
            lcdHistory.AppendText("√" + sqrt + " = ");
            sqrt = Math.Sqrt(sqrt);
            lcdResult.Text = Convert.ToString(sqrt);
            lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);
        }

        //"+/-" - sign inversion - button.
        private void button_plus_or_minus_Click(object sender, EventArgs e)
        {
            double plusOrminus = Double.Parse(lcdResult.Text);
            lcdSecond.Text = Convert.ToString(lcdResult.Text);
            plusOrminus = Convert.ToDouble(lcdResult.Text)*Convert.ToDouble(-1);
            lcdResult.Text = Convert.ToString(plusOrminus);
        }

        //"ln" - natural logarithm - button.
        private void button_ln_Click(object sender, EventArgs e)
        {
            double ln = Double.Parse(lcdResult.Text);
            lcdSecond.Text = Convert.ToString("ln" + "(" + (lcdResult.Text) + ")");
            lcdHistory.AppendText("ln(" + ln + ") = ");
            ln = Math.Log(ln);
            lcdResult.Text = Convert.ToString(ln);
            lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);
        }

        //"x^3" - 'X' to the power of 3 - button.
        private void button_x_to_the_power_of_3_Click(object sender, EventArgs e)
        {
            double x3 = Double.Parse(lcdResult.Text);
            lcdSecond.Text = Convert.ToString("(" + (lcdResult.Text) + ")" + "^3");
            lcdHistory.AppendText(x3 + "^(3" + ") = ");
            x3 = Convert.ToDouble(lcdResult.Text) * Convert.ToDouble(lcdResult.Text) * Convert.ToDouble(lcdResult.Text);
            lcdResult.Text = Convert.ToString(x3);
            lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);
        }

        //"x^2" - 'X' to the power of 2 - button.
        private void button_x_to_the_power_of_2_Click(object sender, EventArgs e)
        {
            double x2 = Double.Parse(lcdResult.Text);
            lcdSecond.Text = Convert.ToString("(" + (lcdResult.Text) + ")" + "^2");
            lcdHistory.AppendText(x2 + "^(2" + ") = ");
            x2 = Convert.ToDouble(lcdResult.Text) * Convert.ToDouble(lcdResult.Text);
            lcdResult.Text = Convert.ToString(x2);
            lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);
        }

        //"sin" - trigonometric function - sine - button.
        private void button_sin_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(lcdResult.Text);
            lcdSecond.Text = Convert.ToString("sin" + "(" + (lcdResult.Text) + ")");
            lcdHistory.AppendText("sin" + "(" + sin+ ") = ");
            sin = Math.Sin(sin);
            lcdResult.Text = Convert.ToString(sin);
            lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);
        }

        //"sinh" - trigonometric function - hyperbolic sine - button.
        private void button_sinh_Click(object sender, EventArgs e)
        {
            double sinh = Double.Parse(lcdResult.Text);
            lcdSecond.Text = Convert.ToString("sinh" + "(" + (lcdResult.Text) + ")");
            lcdHistory.AppendText("sinh" + "(" + sinh + ") = ");
            sinh = Math.Sinh(sinh);
            lcdResult.Text = Convert.ToString(sinh);
            lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);
        }

        //"cos" - trigonometric function - cosine - button.
        private void button_cos_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(lcdResult.Text);
            lcdSecond.Text = Convert.ToString("cos" + "(" + (lcdResult.Text) + ")");
            lcdHistory.AppendText("cos" + "(" + cos + ") = ");
            cos = Math.Cos(cos);
            lcdResult.Text = Convert.ToString(cos);
            lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);
        }

        //"cosh" - trigonometric function - hyperbolic cosine - button.
        private void button_cosh_Click(object sender, EventArgs e)
        {
            double cosh = Double.Parse(lcdResult.Text);
            lcdSecond.Text = Convert.ToString("cosh" + "(" + (lcdResult.Text) + ")");
            lcdHistory.AppendText("cosh" + "(" + cosh + ") = ");
            cosh = Math.Cosh(cosh);
            lcdResult.Text = Convert.ToString(cosh);
            lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);
        }

        //"tan" - trigonometric function -  tangent - button.
        private void button_tan_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(lcdResult.Text);
            lcdSecond.Text = Convert.ToString("tan" + "(" + (lcdResult.Text) + ")");
            lcdHistory.AppendText("tan" + "(" + tan + ") = ");
            tan = Math.Tan(tan);
            lcdResult.Text = Convert.ToString(tan);
            lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);
        }

        //"tanh" - trigonometric function - hyperbolic tangent - button.
        private void button_tanh_Click(object sender, EventArgs e)
        {
            double tanh = Double.Parse(lcdResult.Text);
            lcdSecond.Text = Convert.ToString("tan" + "(" + (lcdResult.Text) + ")");
            lcdHistory.AppendText("tanh" + "(" + tanh + ") = ");
            tanh = Math.Tanh(tanh);
            lcdResult.Text = Convert.ToString(tanh);
            lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);
        }

        //Backspace button - delete the last character.
        private void button_backspace_Click(object sender, EventArgs e)
        {
            if (lcdResult.Text.Length > 1)
                lcdResult.Text = lcdResult.Text.Remove(lcdResult.Text.Length - 1, 1);
            else
                lcdResult.Text = "0";
        }

        //"x^y" - 'X' to the power of 'Y' - button.
        private void button_x_to_the_power_of_y_Click(object sender, EventArgs e)
        {
            double value = 0;
            ++NumberOfClickXY;
            switch (NumberOfClickXY)
            {
                case 1:
                    x1 = Double.Parse(lcdResult.Text);
                    lcdResult.Text = Convert.ToString("0");
                    lcdSecond.Text = Convert.ToString(x1 + "^");
                    button_result.Enabled = false;
                    break;
                case 2:
                    y1 = Double.Parse(lcdResult.Text);
                    lcdSecond.Text = Convert.ToString(x1 + "^" + y1);
                    value = Math.Pow(x1, y1);
                    lcdResult.Text = Convert.ToString(value);
                    lcdHistory.AppendText(x1 + " ^ " + y1 + "  =  " + "");
                    lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);
                    x1 = 0;
                    y1 = 0;
                    value = 0;
                    NumberOfClickXY = 0;
                    button_result.Enabled = true; 
                    break;
            }
        }

        //"e^x" - 'E' to the power of 'X' - button.
        private void button_e_to_the_power_of_x_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(lcdResult.Text);
            double eValue = Math.E;
            lcdSecond.Text = Convert.ToString("e^" + (lcdResult.Text));
            lcdHistory.AppendText("e" + " ^ (" + x + ") = ");
            x = Math.Pow(eValue, x);
            lcdResult.Text = Convert.ToString(x);
            lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);
        }

        //"x^1" - 'X' to the power of '1' - button.
        private void button_x_to_the_power_of_1_slash_y_Click(object sender, EventArgs e)
        {
            double value = 0;
            ++NumberOfClickX1Y;
            switch (NumberOfClickX1Y)
            {
                case 1:
                    x1 = Double.Parse(lcdResult.Text);
                    button_result.Enabled = false;
                    lcdSecond.Text = Convert.ToString("the " + x1 + "-th root of?");
                    lcdResult.Text = Convert.ToString("0");
                    break;
                case 2:
                    y1 = Double.Parse(lcdResult.Text);
                    value = Math.Pow(y1, (1.0 / x1));
                    lcdSecond.Text = Convert.ToString("the " + x1 + "-th root of(" + y1 + ")");
                    lcdHistory.AppendText("the " + x1 + "-th root of(" + y1 + ") = ");
                    lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);
                    lcdResult.Text = Convert.ToString(value);
                    x1 = 0;
                    y1 = 0;
                    value = 0;
                    NumberOfClickX1Y = 0;
                    button_result.Enabled = true;
                    break;
            }
        }

        //"(x^3)/3" - ('X' to the power of '1')/'3' - button.
        private void button_x_to_the_power_of_1_slash_3_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(lcdResult.Text);
            lcdSecond.Text = Convert.ToString("the 3-th root of(" + (lcdResult.Text)+")");
            lcdHistory.AppendText("the 3-th root of(" + x + ") = ");
            x = Math.Pow(x,(1.0/3));
            lcdResult.Text = Convert.ToString(x);
            lcdHistory.AppendText("" + lcdResult.Text + Environment.NewLine);
        }

        //"MC" - button - memory clear (sets the memory to 0).
        private void button_MC_Click(object sender, EventArgs e)
        {
            memory = 0;
            mLight.Visible = false;
        }

        //"MR" - button - memory recall (uses the number in memory).
        private void button_MR_Click(object sender, EventArgs e)
        {
            lcdResult.Text = Convert.ToString(memory);
        }

        //"MS" - button - memory store (puts the number on the display into the memory).
        private void button_MS_Click(object sender, EventArgs e)
        {
            memory = 0;
            double m = Double.Parse(lcdResult.Text);
            memory = memory + m;
        }

        //"M+" - button - add the current value to the stored value.
        private void button_mPlus_Click(object sender, EventArgs e)
        {
            double m = Double.Parse(lcdResult.Text);
            memory = memory + m;
            mLight.Visible = true;
        }

        //"M-" - button - subtract the current value from the stored value.
        private void button_mMinus_Click(object sender, EventArgs e)
        {
            double m = Double.Parse(lcdResult.Text);
            memory = memory - m;
        }

        //"10^x" - '10' to the power of 'X' - button.
        private void button_10_to_the_power_of_x_Click(object sender, EventArgs e)
        {
            double x10 = Double.Parse(lcdResult.Text);
            double value;
            lcdSecond.Text = Convert.ToString("10^(" + lcdResult.Text + ")");
            lcdHistory.AppendText("10^(" + lcdResult.Text + ") = ");
            value = Math.Pow(10, x10);
            lcdResult.Text = Convert.ToString(value);
            lcdHistory.AppendText("" + value + Environment.NewLine);
        }

        //Factorial - button.
        private void button_factorial_Click(object sender, EventArgs e)
        {
            double factorialValue = Double.Parse(lcdResult.Text);
            lcdHistory.AppendText(lcdResult.Text + "! = ");
            double factorial = 1;

            for (int i = 1; i <= factorialValue; i++)
            {
                factorial *= i;
            }
            lcdSecond.Text = Convert.ToString((lcdResult.Text) + "!");
            lcdHistory.AppendText("" + factorial + Environment.NewLine);
            lcdResult.Text = Convert.ToString(factorial);
        }
    }
}
