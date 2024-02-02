namespace WinFormsApp1
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
            textBox1 = new TextBox();
            buttonExport = new Button();
            dataGridView1 = new DataGridView();
            ofd = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // buttonExport
            // 
            buttonExport.Location = new Point(12, 41);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(100, 23);
            buttonExport.TabIndex = 1;
            buttonExport.Text = "Export form xls";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(302, 397);
            dataGridView1.TabIndex = 2;
            // 
            // ofd
            // 
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.FileName = "openFileDialog1";
            ofd.Filter = "Excel 2010(*.xlsx)|*.xlsx|Excel 2003(*.xls)|*.xls";
            ofd.Title = "Select document to download data";
            ofd.FileOk += ofd_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 479);
            Controls.Add(dataGridView1);
            Controls.Add(buttonExport);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonExport;
        private DataGridView dataGridView1;
        private OpenFileDialog ofd;
    }
}