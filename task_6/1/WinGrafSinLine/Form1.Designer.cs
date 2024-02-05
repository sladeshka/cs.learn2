namespace WinGrafSinLine
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            labelLast = new Label();
            labelSecond = new Label();
            labelFirst = new Label();
            buttonCalculation = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(labelLast);
            groupBox1.Controls.Add(labelSecond);
            groupBox1.Controls.Add(labelFirst);
            groupBox1.Controls.Add(buttonCalculation);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 73);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // labelLast
            // 
            labelLast.AutoSize = true;
            labelLast.Location = new Point(313, 24);
            labelLast.Name = "labelLast";
            labelLast.Size = new Size(22, 15);
            labelLast.TabIndex = 5;
            labelLast.Text = "*x)";
            // 
            // labelSecond
            // 
            labelSecond.AutoSize = true;
            labelSecond.Location = new Point(145, 24);
            labelSecond.Name = "labelSecond";
            labelSecond.Size = new Size(56, 15);
            labelSecond.TabIndex = 4;
            labelSecond.Text = "*x) + Sin(";
            // 
            // labelFirst
            // 
            labelFirst.AutoSize = true;
            labelFirst.Location = new Point(6, 24);
            labelFirst.Name = "labelFirst";
            labelFirst.Size = new Size(27, 15);
            labelFirst.TabIndex = 3;
            labelFirst.Text = "Sin(";
            // 
            // buttonCalculation
            // 
            buttonCalculation.Location = new Point(364, 21);
            buttonCalculation.Name = "buttonCalculation";
            buttonCalculation.Size = new Size(75, 23);
            buttonCalculation.TabIndex = 2;
            buttonCalculation.Text = "Calculation";
            buttonCalculation.UseVisualStyleBackColor = true;
            buttonCalculation.Click += buttonCalculation_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(207, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 201);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 304);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonCalculation;
        private Panel panel1;
        private Label labelFirst;
        private Label labelSecond;
        private Label labelLast;
    }
}