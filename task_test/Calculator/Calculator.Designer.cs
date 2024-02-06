namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            engineeringToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button_Sqrt = new Button();
            button_Power = new Button();
            button_Square = new Button();
            button_Sqrt_3 = new Button();
            button_factor = new Button();
            button_quadratic_equation = new Button();
            button_Divide = new Button();
            button_Multiply = new Button();
            button0 = new Button();
            button9 = new Button();
            button_Inverse = new Button();
            button_Backspace = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button_Dot = new Button();
            button3 = new Button();
            button_Equal = new Button();
            button2 = new Button();
            button_Add = new Button();
            button_CE = new Button();
            button_Minus = new Button();
            button_C = new Button();
            label1 = new Label();
            toolTip = new ToolTip(components);
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(260, 24);
            menuStrip1.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { engineeringToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // engineeringToolStripMenuItem
            // 
            engineeringToolStripMenuItem.Name = "engineeringToolStripMenuItem";
            engineeringToolStripMenuItem.Size = new Size(148, 22);
            engineeringToolStripMenuItem.Text = "Инженерный";
            engineeringToolStripMenuItem.Click += engineeringToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(148, 22);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(68, 20);
            helpToolStripMenuItem.Text = "Помощь";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(149, 22);
            aboutToolStripMenuItem.Text = "О программе";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button_Sqrt);
            groupBox1.Controls.Add(button_Power);
            groupBox1.Controls.Add(button_Square);
            groupBox1.Controls.Add(button_Sqrt_3);
            groupBox1.Controls.Add(button_factor);
            groupBox1.Controls.Add(button_quadratic_equation);
            groupBox1.Controls.Add(button_Divide);
            groupBox1.Controls.Add(button_Multiply);
            groupBox1.Controls.Add(button0);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button_Inverse);
            groupBox1.Controls.Add(button_Backspace);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button_Dot);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button_Equal);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button_Add);
            groupBox1.Controls.Add(button_CE);
            groupBox1.Controls.Add(button_Minus);
            groupBox1.Controls.Add(button_C);
            groupBox1.Location = new Point(12, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 331);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Калькулятор";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 23);
            textBox1.TabIndex = 25;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(6, 53);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 2;
            button1.Text = "1";
            toolTip.SetToolTip(button1, "Это кнопка 1");
            button1.Click += Button_Click;
            // 
            // button_Sqrt
            // 
            button_Sqrt.Location = new Point(190, 237);
            button_Sqrt.Name = "button_Sqrt";
            button_Sqrt.Size = new Size(40, 40);
            button_Sqrt.TabIndex = 20;
            button_Sqrt.Text = "√";
            button_Sqrt.Visible = false;
            button_Sqrt.Click += Button_Sqrt_Click;
            // 
            // button_Power
            // 
            button_Power.Location = new Point(144, 237);
            button_Power.Name = "button_Power";
            button_Power.Size = new Size(40, 40);
            button_Power.TabIndex = 19;
            button_Power.Text = "x^y";
            button_Power.Visible = false;
            button_Power.Click += Button_Click_Operation;
            // 
            // button_Square
            // 
            button_Square.Location = new Point(144, 283);
            button_Square.Name = "button_Square";
            button_Square.Size = new Size(40, 40);
            button_Square.TabIndex = 22;
            button_Square.Text = "x^2";
            button_Square.Visible = false;
            button_Square.Click += Button_Square_Click;
            // 
            // button_Sqrt_3
            // 
            button_Sqrt_3.Location = new Point(190, 283);
            button_Sqrt_3.Name = "button_Sqrt_3";
            button_Sqrt_3.Size = new Size(40, 40);
            button_Sqrt_3.TabIndex = 20;
            button_Sqrt_3.Text = "∛";
            button_Sqrt_3.Visible = false;
            button_Sqrt_3.Click += Button_Sqrt_3_Click;
            // 
            // button_factor
            // 
            button_factor.Location = new Point(98, 283);
            button_factor.Name = "button_factor";
            button_factor.Size = new Size(40, 40);
            button_factor.TabIndex = 21;
            button_factor.Text = "n!";
            button_factor.Visible = false;
            button_factor.Click += button_factor_Click;
            // 
            // button_quadratic_equation
            // 
            button_quadratic_equation.Location = new Point(6, 237);
            button_quadratic_equation.Name = "button_quadratic_equation";
            button_quadratic_equation.Size = new Size(86, 86);
            button_quadratic_equation.TabIndex = 21;
            button_quadratic_equation.Text = "aх2+bx+c=0";
            button_quadratic_equation.Visible = false;
            button_quadratic_equation.Click += button_quadratic_equation_Click;
            // 
            // button_Divide
            // 
            button_Divide.Location = new Point(144, 191);
            button_Divide.Name = "button_Divide";
            button_Divide.Size = new Size(40, 40);
            button_Divide.TabIndex = 15;
            button_Divide.Text = "÷";
            button_Divide.Click += Button_Click_Operation;
            // 
            // button_Multiply
            // 
            button_Multiply.Location = new Point(144, 145);
            button_Multiply.Name = "button_Multiply";
            button_Multiply.Size = new Size(40, 40);
            button_Multiply.TabIndex = 14;
            button_Multiply.Text = "×";
            button_Multiply.Click += Button_Click_Operation;
            // 
            // button0
            // 
            button0.Location = new Point(52, 191);
            button0.Name = "button0";
            button0.Size = new Size(40, 40);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.Click += Button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(98, 145);
            button9.Name = "button9";
            button9.Size = new Size(40, 40);
            button9.TabIndex = 10;
            button9.Text = "9";
            toolTip.SetToolTip(button9, "Это кнопка 9");
            button9.Click += Button_Click;
            // 
            // button_Inverse
            // 
            button_Inverse.Location = new Point(98, 237);
            button_Inverse.Name = "button_Inverse";
            button_Inverse.Size = new Size(40, 40);
            button_Inverse.TabIndex = 21;
            button_Inverse.Text = "1/x";
            button_Inverse.Visible = false;
            button_Inverse.Click += Button_Inverse_Click;
            // 
            // button_Backspace
            // 
            button_Backspace.Location = new Point(190, 53);
            button_Backspace.Name = "button_Backspace";
            button_Backspace.Size = new Size(40, 40);
            button_Backspace.TabIndex = 18;
            button_Backspace.Text = "←";
            button_Backspace.Click += Button_Backspace_Click;
            // 
            // button8
            // 
            button8.Location = new Point(52, 145);
            button8.Name = "button8";
            button8.Size = new Size(40, 40);
            button8.TabIndex = 9;
            button8.Text = "8";
            toolTip.SetToolTip(button8, "Это кнопка 8");
            button8.Click += Button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(6, 145);
            button7.Name = "button7";
            button7.Size = new Size(40, 40);
            button7.TabIndex = 8;
            button7.Text = "7";
            toolTip.SetToolTip(button7, "Это кнопка 7");
            button7.Click += Button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(98, 99);
            button6.Name = "button6";
            button6.Size = new Size(40, 40);
            button6.TabIndex = 7;
            button6.Text = "6";
            toolTip.SetToolTip(button6, "Это кнопка 6");
            button6.Click += Button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(52, 99);
            button5.Name = "button5";
            button5.Size = new Size(40, 40);
            button5.TabIndex = 6;
            button5.Text = "5";
            toolTip.SetToolTip(button5, "Это кнопка 5");
            button5.Click += Button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(6, 99);
            button4.Name = "button4";
            button4.Size = new Size(40, 40);
            button4.TabIndex = 5;
            button4.Text = "4";
            toolTip.SetToolTip(button4, "Это кнопка 4");
            button4.Click += Button_Click;
            // 
            // button_Dot
            // 
            button_Dot.Location = new Point(6, 191);
            button_Dot.Name = "button_Dot";
            button_Dot.Size = new Size(40, 40);
            button_Dot.TabIndex = 23;
            button_Dot.Text = ".";
            button_Dot.Click += Button_Dot_Click;
            // 
            // button3
            // 
            button3.Location = new Point(98, 53);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 4;
            button3.Text = "3";
            toolTip.SetToolTip(button3, "Это кнопка 3");
            button3.Click += Button_Click;
            // 
            // button_Equal
            // 
            button_Equal.Location = new Point(190, 145);
            button_Equal.Name = "button_Equal";
            button_Equal.Size = new Size(40, 86);
            button_Equal.TabIndex = 24;
            button_Equal.Text = "=";
            button_Equal.Click += Button_Equal_Click;
            // 
            // button2
            // 
            button2.Location = new Point(52, 53);
            button2.Name = "button2";
            button2.Size = new Size(40, 40);
            button2.TabIndex = 3;
            button2.Text = "2";
            toolTip.SetToolTip(button2, "Это кнопка 2");
            button2.Click += Button_Click;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(144, 53);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(40, 40);
            button_Add.TabIndex = 12;
            button_Add.Text = "+";
            button_Add.Click += Button_Click_Operation;
            // 
            // button_CE
            // 
            button_CE.Location = new Point(190, 99);
            button_CE.Name = "button_CE";
            button_CE.Size = new Size(40, 40);
            button_CE.TabIndex = 16;
            button_CE.Text = "CE";
            button_CE.Click += Button_CE_Click;
            // 
            // button_Minus
            // 
            button_Minus.Location = new Point(144, 99);
            button_Minus.Name = "button_Minus";
            button_Minus.Size = new Size(40, 40);
            button_Minus.TabIndex = 13;
            button_Minus.Text = "-";
            button_Minus.Click += Button_Click_Operation;
            // 
            // button_C
            // 
            button_C.Location = new Point(98, 191);
            button_C.Name = "button_C";
            button_C.Size = new Size(40, 40);
            button_C.TabIndex = 17;
            button_C.Text = "C";
            button_C.Click += Button_C_Click;
            // 
            // label1
            // 
            label1.Location = new Point(220, 10);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 26;
            // 
            // Calculator
            // 
            BackColor = Color.LightSalmon;
            ClientSize = new Size(260, 376);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            Load += Calculator_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button button_Add;
        private Button button_Minus;
        private Button button_Multiply;
        private Button button_Divide;
        private Button button_CE;
        private Button button_C;
        private Button button_Backspace;
        private Button button_Power;
        private Button button_Sqrt;
        private Button button_Inverse;
        private Button button_Square;
        private Button button_Sqrt_3;
        private Button button_factor;
        private Button button_quadratic_equation;
        private Button button_Dot;
        private Button button_Equal;
        private Label label1;
        private ToolTip toolTip;
        private ToolStripMenuItem engineeringToolStripMenuItem;
    }
}