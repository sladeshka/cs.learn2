namespace WinAnim
{
    partial class FormAnimation
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
            buttonAWBLEND = new Button();
            buttonHORAWSLIDE = new Button();
            buttonCenterAWSLIDE = new Button();
            SuspendLayout();
            // 
            // buttonAWBLEND
            // 
            buttonAWBLEND.Location = new Point(12, 12);
            buttonAWBLEND.Name = "buttonAWBLEND";
            buttonAWBLEND.Size = new Size(210, 23);
            buttonAWBLEND.TabIndex = 0;
            buttonAWBLEND.Text = "Appearance";
            buttonAWBLEND.UseVisualStyleBackColor = true;
            buttonAWBLEND.Click += buttonAW_BLEND_Click;
            // 
            // buttonHORAWSLIDE
            // 
            buttonHORAWSLIDE.Location = new Point(12, 41);
            buttonHORAWSLIDE.Name = "buttonHORAWSLIDE";
            buttonHORAWSLIDE.Size = new Size(210, 23);
            buttonHORAWSLIDE.TabIndex = 1;
            buttonHORAWSLIDE.Text = "Horizontal appearance";
            buttonHORAWSLIDE.UseVisualStyleBackColor = true;
            buttonHORAWSLIDE.Click += buttonHOR_AW_SLIDE_Click;
            // 
            // buttonCenterAWSLIDE
            // 
            buttonCenterAWSLIDE.Location = new Point(12, 70);
            buttonCenterAWSLIDE.Name = "buttonCenterAWSLIDE";
            buttonCenterAWSLIDE.Size = new Size(210, 23);
            buttonCenterAWSLIDE.TabIndex = 2;
            buttonCenterAWSLIDE.Text = "Emergence from the center";
            buttonCenterAWSLIDE.UseVisualStyleBackColor = true;
            buttonCenterAWSLIDE.Click += buttonAW_SLIDE_Click;
            // 
            // FormAnimation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 210);
            Controls.Add(buttonCenterAWSLIDE);
            Controls.Add(buttonHORAWSLIDE);
            Controls.Add(buttonAWBLEND);
            Name = "FormAnimation";
            Text = "Form Animation";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAWBLEND;
        private Button buttonHORAWSLIDE;
        private Button buttonCenterAWSLIDE;
    }
}