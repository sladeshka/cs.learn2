namespace EditPerson
{
    partial class EditPersonForm
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
            labelName = new Label();
            labelSurname = new Label();
            labelAge = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            numericUpDownAge = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 17);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(12, 46);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(54, 15);
            labelSurname.TabIndex = 1;
            labelSurname.Text = "Surname";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(12, 75);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(28, 15);
            labelAge.TabIndex = 2;
            labelAge.Text = "Age";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(83, 17);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(169, 23);
            textBoxName.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(83, 46);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(169, 23);
            textBoxSurname.TabIndex = 4;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(12, 135);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(177, 135);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(83, 73);
            numericUpDownAge.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(169, 23);
            numericUpDownAge.TabIndex = 8;
            numericUpDownAge.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // EditPersonForm
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(264, 173);
            Controls.Add(numericUpDownAge);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(labelAge);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Name = "EditPersonForm";
            ShowInTaskbar = false;
            Text = "Edit employee";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelSurname;
        private Label labelAge;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private Button buttonSave;
        private Button buttonCancel;
        private NumericUpDown numericUpDownAge;
    }
}