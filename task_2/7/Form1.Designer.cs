namespace RegistrationForm
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
            checkExtendedСapabilities = new CheckBox();
            groupRegDetails = new GroupBox();
            lableForPIN = new Label();
            lableForName = new Label();
            textBoxForName = new TextBox();
            textBoxForPIN = new TextBox();
            FormTitle = new Label();
            buttonRegister = new Button();
            groupRegDetails.SuspendLayout();
            SuspendLayout();
            // 
            // FormTitle
            // 
            FormTitle.AutoSize = true;
            FormTitle.Location = new Point(12, 9);
            FormTitle.Name = "FormTitle";
            FormTitle.Size = new Size(127, 15);
            FormTitle.TabIndex = 2;
            FormTitle.Text = "Select registration type";
            // 
            // groupRegDetails
            // 
            groupRegDetails.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupRegDetails.Controls.Add(lableForPIN);
            groupRegDetails.Controls.Add(lableForName);
            groupRegDetails.Controls.Add(textBoxForName);
            groupRegDetails.Controls.Add(textBoxForPIN);
            groupRegDetails.Location = new Point(12, 63);
            groupRegDetails.Name = "groupRegDetails";
            groupRegDetails.Size = new Size(376, 90);
            groupRegDetails.TabIndex = 1;
            groupRegDetails.TabStop = false;
            groupRegDetails.Text = "Enter registration details";
            // 
            // lableForName
            // 
            lableForName.AutoSize = true;
            lableForName.Location = new Point(31, 22);
            lableForName.Name = "lableForName";
            lableForName.Size = new Size(39, 15);
            lableForName.TabIndex = 2;
            lableForName.Text = "Name";
            // 
            // textBoxForName
            // 
            textBoxForName.Location = new Point(101, 22);
            textBoxForName.Name = "textBoxForName";
            textBoxForName.Size = new Size(269, 23);
            textBoxForName.TabIndex = 1;
            // 
            // lableForPIN
            // 
            lableForPIN.AutoSize = true;
            lableForPIN.Location = new Point(31, 51);
            lableForPIN.Name = "lableForPIN";
            lableForPIN.Size = new Size(68, 15);
            lableForPIN.TabIndex = 3;
            lableForPIN.Text = "PIN";
            // 
            // textBoxForPIN
            // 
            textBoxForPIN.Location = new Point(101, 51);
            textBoxForPIN.Name = "textBoxForPIN";
            textBoxForPIN.Size = new Size(269, 23);
            textBoxForPIN.TabIndex = 0;
            // 
            // checkExtendedСapabilities
            // 
            checkExtendedСapabilities.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkExtendedСapabilities.AutoSize = true;
            checkExtendedСapabilities.Location = new Point(12, 169);
            checkExtendedСapabilities.Name = "checkExtendedСapabilities";
            checkExtendedСapabilities.Size = new Size(137, 19);
            checkExtendedСapabilities.TabIndex = 0;
            checkExtendedСapabilities.Text = "Extended capabilities";
            checkExtendedСapabilities.UseVisualStyleBackColor = true;
            checkExtendedСapabilities.CheckedChanged += checkExtendedСapabilities_CheckedChanged;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(310, 275);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(78, 23);
            buttonRegister.TabIndex = 3;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 310);
            Controls.Add(buttonRegister);
            Controls.Add(FormTitle);
            Controls.Add(groupRegDetails);
            Controls.Add(checkExtendedСapabilities);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Registration";
            groupRegDetails.ResumeLayout(false);
            groupRegDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkExtendedСapabilities;
        private GroupBox groupRegDetails;
        private Label FormTitle;
        private Button buttonRegister;
        private Label lableForPIN;
        private Label lableForName;
        private TextBox textBoxForName;
        private TextBox textBoxForPIN;
    }
}