using System.Windows.Forms;

namespace DataValidationForm
{
    partial class DataValidationForm
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            phoneTextBox = new TextBox();
            submitButton = new Button();
            userInfoLabel = new Label();
            errorProvider1 = new ErrorProvider(components);
            namelabel = new Label();
            emaillabel = new Label();
            phonelabel = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(57, 9);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(131, 23);
            nameTextBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(57, 41);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(131, 23);
            emailTextBox.TabIndex = 1;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(57, 70);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(131, 23);
            phoneTextBox.TabIndex = 2;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(12, 99);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 3;
            submitButton.Text = "Validate";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // userInfoLabel
            // 
            userInfoLabel.AutoSize = true;
            userInfoLabel.Location = new Point(12, 135);
            userInfoLabel.Name = "userInfoLabel";
            userInfoLabel.Size = new Size(28, 15);
            userInfoLabel.TabIndex = 4;
            userInfoLabel.Text = "Info";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(12, 9);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(39, 15);
            namelabel.TabIndex = 5;
            namelabel.Text = "Name";
            // 
            // emaillabel
            // 
            emaillabel.AutoSize = true;
            emaillabel.Location = new Point(12, 41);
            emaillabel.Name = "emaillabel";
            emaillabel.Size = new Size(36, 15);
            emaillabel.TabIndex = 6;
            emaillabel.Text = "Email";
            // 
            // phonelabel
            // 
            phonelabel.AutoSize = true;
            phonelabel.Location = new Point(12, 70);
            phonelabel.Name = "phonelabel";
            phonelabel.Size = new Size(41, 15);
            phonelabel.TabIndex = 7;
            phonelabel.Text = "Phone";
            phonelabel.Click += phonelabel_Click;
            // 
            // DataValidationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(phonelabel);
            Controls.Add(emaillabel);
            Controls.Add(namelabel);
            Controls.Add(userInfoLabel);
            Controls.Add(submitButton);
            Controls.Add(phoneTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Name = "DataValidationForm";
            Size = new Size(211, 160);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private TextBox phoneTextBox;
        private Button submitButton;
        private Label userInfoLabel;
        private ErrorProvider errorProvider1;
        private Label phonelabel;
        private Label emaillabel;
        private Label namelabel;
    }
}
