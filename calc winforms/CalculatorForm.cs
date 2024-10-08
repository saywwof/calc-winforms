using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_winforms
{
    public partial class CalculatorForm : Form
    {
        private Calculator calc = new Calculator();

        public CalculatorForm()
        {
            InitializeComponent();
            calc = new Calculator();
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = calc.Add(a, b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = calc.Sub(a, b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = calc.Mul(a, b).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            if (b != 0)
            {
                textBox3.Text = calc.Div(a, b).ToString();
            }
            else
            {
                textBox3.Text = "Ошибка: деление на ноль!";
            }
        }
    }
}
