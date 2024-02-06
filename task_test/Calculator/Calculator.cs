using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Numerics;

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
        private void button_factor_Click(object sender, EventArgs e)
        {
            // Расчет факториала
            if (num1 != null)
            {
                ulong factorial = 1;
                for (ulong i = 1; i <= double.Parse(num1); i++)
                {
                    factorial *= i;
                }
                textBox1.Text = factorial.ToString();
                num1 = factorial.ToString();
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

        private void engineeringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_Inverse.Visible = true;
            button_Square.Visible = true;
            button_Power.Visible = true;
            button_Sqrt.Visible = true;
            button_Sqrt_3.Visible = true;
            button_factor.Visible = true;
            button_quadratic_equation.Visible = true;
            ClientSize = new Size(260, 380);
            groupBox1.Size = new Size(240, 335);
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            groupBox1.Size = new Size(240, 243);
            ClientSize = new Size(260, 288);
        }

        private void button_quadratic_equation_Click(object sender, EventArgs e)
        {
            // Создать окно диалога для ввода коэффициентов квадратного уравнения.
            EquationDialog dialog = new EquationDialog();

            // Отобразить окно диалога.
            DialogResult result = dialog.ShowDialog();

            // Если пользователь нажал кнопку "ОК", получить коэффициенты уравнения.
            if (result == DialogResult.OK)
            {
                double a = dialog.A;
                double b = dialog.B;
                double c = dialog.C;

                // Вычислить дискриминант уравнения.
                double discriminant = b * b - 4 * a * c;

                // Если дискриминант меньше нуля, уравнение не имеет действительных корней.
                if (discriminant < 0)
                {
                    textBox1.Text = "Не имеет корней.";
                }
                // Если дискриминант равен нулю, уравнение имеет один действительный корень.
                else if (discriminant == 0)
                {
                    double x = -b / (2 * a);
                    textBox1.Text = $"Имеет один корень: x = {x}";
                }
                // Если дискриминант больше нуля, уравнение имеет два действительных корня.
                else
                {
                    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    textBox1.Text = $"Имеет два корня: x1 = {x1}, x2 = {x2}";
                }
            }
        }
    }
}