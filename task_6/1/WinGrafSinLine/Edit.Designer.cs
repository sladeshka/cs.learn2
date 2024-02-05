namespace WinGrafSinLine
{
    partial class Edit
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonCalculation = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // buttonCalculation
            // 
            buttonCalculation.DialogResult = DialogResult.OK;
            buttonCalculation.Location = new Point(12, 70);
            buttonCalculation.Name = "buttonCalculation";
            buttonCalculation.Size = new Size(75, 23);
            buttonCalculation.TabIndex = 2;
            buttonCalculation.Text = "Calculation";
            buttonCalculation.UseVisualStyleBackColor = true;
            buttonCalculation.Click += button1_Click;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(139, 121);
            Controls.Add(buttonCalculation);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Edit";
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonCalculation;
    }
}