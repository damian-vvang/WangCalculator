using System;
using System.Windows.Forms;

namespace WangCalculator
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        //Unit Converter - button.
        private void button_unit_converter_Click(object sender, EventArgs e)
        {
            UnitConverter unitConverter = new UnitConverter();
            unitConverter.ShowDialog();
        }

        //Numeral systems calculator - button.
        private void button_numeral_system_calculator_Click(object sender, EventArgs e)
        {
            NumeralSystemsCalculator numeralSystemsCalculator = new NumeralSystemsCalculator();
            numeralSystemsCalculator.ShowDialog();
        }

        //Complex numbers calculator - button.
        private void button_complex_numbers_calculator_Click(object sender, EventArgs e)
        {
            ComplexNumbersCalculator complexNumbersCalculator = new ComplexNumbersCalculator();
            complexNumbersCalculator.ShowDialog();
        }
    }
}
