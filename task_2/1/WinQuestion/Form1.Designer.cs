namespace WinQuestion
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
            ButtonYes = new Button();
            ButtonNo = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ButtonYes
            // 
            ButtonYes.Location = new Point(77, 102);
            ButtonYes.Name = "ButtonYes";
            ButtonYes.Size = new Size(75, 23);
            ButtonYes.TabIndex = 0;
            ButtonYes.Text = "Yes";
            ButtonYes.UseVisualStyleBackColor = true;
            ButtonYes.Click += ButtonYes_Click;
            // 
            // ButtonNo
            // 
            ButtonNo.Location = new Point(187, 102);
            ButtonNo.Name = "ButtonNo";
            ButtonNo.Size = new Size(75, 23);
            ButtonNo.TabIndex = 1;
            ButtonNo.Text = "No";
            ButtonNo.UseVisualStyleBackColor = true;
            ButtonNo.TabStop = false;
            ButtonNo.Click += ButtonNo_Click;
            ButtonNo.MouseMove += ButtonNo_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 56);
            label1.Name = "label1";
            label1.Size = new Size(185, 15);
            label1.TabIndex = 2;
            label1.Text = "Are you satisfied with your salary?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 200);
            Controls.Add(label1);
            Controls.Add(ButtonNo);
            Controls.Add(ButtonYes);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "The pressing question";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonYes;
        private Button ButtonNo;
        private Label label1;
    }
}