using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Calculator
{
    public partial class Calculator : Form
    {
        public string? num1;
        public string? num2;
        public string? operation;
        public Calculator()
        {
            InitializeComponent();
            num1 = "0";
            textBox1.Text = num1;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            // Добавление цифры в поле ввода
            if (operation == null)
            {
                if (num1 != null && num1 != "0")
                {
                    num1 += ((Button)sender).Text;
                }
                else
                {
                    num1 = ((Button)sender).Text;
                }
                textBox1.Text = num1;
            }
            if (operation != null)
            {
                if (num2 != null && num1 != "0")
                {
                    num2 += ((Button)sender).Text;
                }
                else
                {
                    num2 = ((Button)sender).Text;
                }
                textBox1.Text = num2;
            }
        }
        private void Button_Click_Operation(object sender, EventArgs e)
        {
            if (num1 != null)
            {
                operation = ((Button)sender).Text;
            }
        }
        private void Button_CE_Click(object sender, EventArgs e)
        {
            num2 = operation = null;
            textBox1.Text = num1;
        }
        private void Button_C_Click(object sender, EventArgs e)
        {
            num1 = "0";
            num2 = operation = null;
            textBox1.Text = num1;
        }
        private void Button_Backspace_Click(object sender, EventArgs e)
        {
            // Удаление последнего символа из поля ввода
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                textBox1.Text = textBox1.Text.Length == 0 ? "0" : textBox1.Text;
                if (operation == null)
                {
                    num1 = textBox1.Text;
                }
                if (operation != null)
                {
                    num2 = textBox1.Text;
                }
            }
        }
        private void Button_Sqrt_Click(object sender, EventArgs e)
        {
            // Извлечение квадратного корня
            if (num1 != null)
            {
                string sqrt = (Math.Sqrt(double.Parse(num1))).ToString();
                textBox1.Text = sqrt;
                num1 = sqrt;
            }
        }

        private void Button_Sqrt_3_Click(object sender, EventArgs e)
        {
            // Извлечение квадратного корня
            if (num1 != null)
            {
                string sqrt_3 = (Math.Pow(double.Parse(num1), 1.0 / 3.0)).ToString();
                textBox1.Text = sqrt_3;
                num1 = sqrt_3;
            }
        }
        private void Button_Inverse_Click(object sender, EventArgs e)
        {
            // Расчет обратного значения (1/x)
            if (num1 != null)
            {
                string inverse = (1 / double.Parse(num1)).ToString();
                textBox1.Text = inverse;
                num1 = inverse;
            }
        }
        private void Button_Square_Click(object sender, EventArgs e)
        {
            // Определение квадрата числа
            if (num1 != null)
            {
                string square = (double.Parse(num1) * double.Parse(num1)).ToString();
                textBox1.Text = square;
                num1 = square;
            }
        }
        private void Button_Dot_Click(object sender, EventArgs e)
        {
            // Добавление десятичной точки в поле ввода
            if (operation == null)
            {
                if (!num1.Contains("."))
                {
                    num1 += ((Button)sender).Text.Replace(".", ",");
                }
                textBox1.Text = num1;
            }
            if (operation != null)
            {
                if (!num2.Contains("."))
                {
                    num2 += ((Button)sender).Text.Replace(".", ",");
                }
                textBox1.Text = num2;
            }
        }
        private void Button_Equal_Click(object sender, EventArgs e)
        {
            // Выполнение операции
            if (num1 != null && num2 != null)
            {
                switch (operation)
                {
                    case "+":
                        textBox1.Text = (double.Parse(num1) + double.Parse(num2)).ToString();
                        break;
                    case "-":
                        textBox1.Text = (double.Parse(num1) - double.Parse(num2)).ToString();
                        break;
                    case "×":
                        textBox1.Text = (double.Parse(num1) * double.Parse(num2)).ToString();
                        break;
                    case "x^y":
                        textBox1.Text = (Math.Pow(double.Parse(num1), double.Parse(num2))).ToString();
                        break;
                    case "÷":
                        if (double.Parse(num2) == 0)
                        {
                            MessageBox.Show("Деление на 0 невозможно");
                            return;
                        }
                        textBox1.Text = (double.Parse(num1) / double.Parse(num2)).ToString();
                        break;
                }
            }
            num1 = textBox1.Text;
            num2 = operation = null;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Отменить ввод символа
            e.Handled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}