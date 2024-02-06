namespace Calculator
{
    partial class EquationDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxB = new TextBox();
            textBoxA = new TextBox();
            textBoxC = new TextBox();
            labelA = new Label();
            labelB = new Label();
            labelC = new Label();
            buttonCalculate = new Button();
            SuspendLayout();
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(157, 12);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(100, 23);
            textBoxB.TabIndex = 0;
            textBoxB.Text = "16";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(31, 12);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(100, 23);
            textBoxA.TabIndex = 1;
            textBoxA.Text = "4";
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(282, 12);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(100, 23);
            textBoxC.TabIndex = 2;
            textBoxC.Text = "10";
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(12, 15);
            labelA.Name = "labelA";
            labelA.Size = new Size(13, 15);
            labelA.TabIndex = 3;
            labelA.Text = "a";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(137, 15);
            labelB.Name = "labelB";
            labelB.Size = new Size(14, 15);
            labelB.TabIndex = 4;
            labelB.Text = "b";
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Location = new Point(263, 15);
            labelC.Name = "labelC";
            labelC.Size = new Size(13, 15);
            labelC.TabIndex = 5;
            labelC.Text = "c";
            // 
            // buttonCalculate
            // 
            buttonCalculate.DialogResult = DialogResult.OK;
            buttonCalculate.Location = new Point(31, 41);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(75, 23);
            buttonCalculate.TabIndex = 6;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // EquationDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 77);
            Controls.Add(buttonCalculate);
            Controls.Add(labelC);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(textBoxC);
            Controls.Add(textBoxA);
            Controls.Add(textBoxB);
            Name = "EquationDialog";
            Text = "Equation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxB;
        private TextBox textBoxA;
        private TextBox textBoxC;
        private Label labelA;
        private Label labelB;
        private Label labelC;
        private Button buttonCalculate;
    }
}