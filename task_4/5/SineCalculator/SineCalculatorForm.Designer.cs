namespace SineCalculator
{
    partial class SineCalculatorForm
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
            txtLowerBound = new TextBox();
            txtUpperBound = new TextBox();
            buttonTransferData = new Button();
            labelIntervalBoundaries = new Label();
            buttonCancelЕransfer = new Button();
            SuspendLayout();
            // 
            // txtLowerBound
            // 
            txtLowerBound.Location = new Point(20, 27);
            txtLowerBound.Name = "txtLowerBound";
            txtLowerBound.Size = new Size(100, 23);
            txtLowerBound.TabIndex = 0;
            txtLowerBound.Text = "0";
            // 
            // txtUpperBound
            // 
            txtUpperBound.Location = new Point(126, 27);
            txtUpperBound.Name = "txtUpperBound";
            txtUpperBound.Size = new Size(100, 23);
            txtUpperBound.TabIndex = 1;
            txtUpperBound.Text = "3,14";
            // 
            // buttonTransferData
            //
            buttonTransferData.DialogResult = DialogResult.OK;
            buttonTransferData.Location = new Point(20, 56);
            buttonTransferData.Name = "buttonTransferData";
            buttonTransferData.Size = new Size(100, 23);
            buttonTransferData.TabIndex = 2;
            buttonTransferData.Text = "Transfer data";
            buttonTransferData.Click += buttonTransferData_Click;
            // 
            // labelIntervalBoundaries
            // 
            labelIntervalBoundaries.AutoSize = true;
            labelIntervalBoundaries.Location = new Point(20, 9);
            labelIntervalBoundaries.Name = "labelIntervalBoundaries";
            labelIntervalBoundaries.Size = new Size(108, 15);
            labelIntervalBoundaries.TabIndex = 3;
            labelIntervalBoundaries.Text = "Interval boundaries";
            // 
            // buttonCancelЕransfer
            // 
            buttonCancelЕransfer.DialogResult = DialogResult.Cancel;
            buttonCancelЕransfer.Location = new Point(126, 56);
            buttonCancelЕransfer.Name = "buttonCancelЕransfer";
            buttonCancelЕransfer.Size = new Size(100, 23);
            buttonCancelЕransfer.TabIndex = 4;
            buttonCancelЕransfer.Text = "Cancel transfer";
            buttonCancelЕransfer.UseVisualStyleBackColor = true;
            // 
            // SineCalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 103);
            Controls.Add(buttonCancelЕransfer);
            Controls.Add(labelIntervalBoundaries);
            Controls.Add(txtLowerBound);
            Controls.Add(txtUpperBound);
            Controls.Add(buttonTransferData);
            Name = "SineCalculatorForm";
            Text = "Sine calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtLowerBound;
        private TextBox txtUpperBound;
        private Button buttonTransferData;

        #endregion

        private Label labelIntervalBoundaries;
        private Button buttonCancelЕransfer;
    }
}