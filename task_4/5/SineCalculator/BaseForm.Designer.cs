namespace SineCalculator
{
    partial class BaseForm
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
            titlelabel = new Label();
            resultlabel = new Label();
            richTextBox1 = new RichTextBox();
            SetIntervalButton = new Button();
            SuspendLayout();
            // 
            // titlelabel
            // 
            titlelabel.AutoSize = true;
            titlelabel.Location = new Point(12, 9);
            titlelabel.Name = "titlelabel";
            titlelabel.Size = new Size(254, 15);
            titlelabel.TabIndex = 0;
            titlelabel.Text = "The values of the sin(x) function in the interval:";
            // 
            // resultlabel
            // 
            resultlabel.AutoSize = true;
            resultlabel.Location = new Point(12, 24);
            resultlabel.Name = "resultlabel";
            resultlabel.Size = new Size(39, 15);
            resultlabel.TabIndex = 1;
            resultlabel.Text = "Result";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 42);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(177, 244);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // SetIntervalButton
            // 
            SetIntervalButton.Location = new Point(191, 42);
            SetIntervalButton.Name = "SetIntervalButton";
            SetIntervalButton.Size = new Size(75, 23);
            SetIntervalButton.TabIndex = 3;
            SetIntervalButton.Text = "Set interval";
            SetIntervalButton.UseVisualStyleBackColor = true;
            SetIntervalButton.Click += SetIntervalButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 300);
            Controls.Add(SetIntervalButton);
            Controls.Add(richTextBox1);
            Controls.Add(resultlabel);
            Controls.Add(titlelabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titlelabel;
        private Label resultlabel;
        private RichTextBox richTextBox1;
        private Button SetIntervalButton;
    }
}