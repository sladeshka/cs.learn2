namespace BiblWorm
{
    partial class Library
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
            tabControl1 = new TabControl();
            Books = new TabPage();
            buttonAdd = new Button();
            checkBoxReturn = new CheckBox();
            checkBoxAvailability = new CheckBox();
            numericUpDownPeriod = new NumericUpDown();
            numericUpDownInventory = new NumericUpDown();
            numericUpDownPublished = new NumericUpDown();
            numericUpDownPages = new NumericUpDown();
            textBoxPublisher = new TextBox();
            textBoxName = new TextBox();
            textBoxAuthor = new TextBox();
            labelAuthor = new Label();
            labelName = new Label();
            labelPublisher = new Label();
            labelPublished = new Label();
            labelPages = new Label();
            labelInventory = new Label();
            labelPeriod = new Label();
            Magazines = new TabPage();
            checkBoxSort = new CheckBox();
            richTextBox1 = new RichTextBox();
            buttonView = new Button();
            tabControl1.SuspendLayout();
            Books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPublished).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPages).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Books);
            tabControl1.Controls.Add(Magazines);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(226, 426);
            tabControl1.TabIndex = 0;
            // 
            // Books
            // 
            Books.Controls.Add(buttonAdd);
            Books.Controls.Add(checkBoxReturn);
            Books.Controls.Add(checkBoxAvailability);
            Books.Controls.Add(numericUpDownPeriod);
            Books.Controls.Add(numericUpDownInventory);
            Books.Controls.Add(numericUpDownPublished);
            Books.Controls.Add(numericUpDownPages);
            Books.Controls.Add(textBoxPublisher);
            Books.Controls.Add(textBoxName);
            Books.Controls.Add(textBoxAuthor);
            Books.Controls.Add(labelAuthor);
            Books.Controls.Add(labelName);
            Books.Controls.Add(labelPublisher);
            Books.Controls.Add(labelPublished);
            Books.Controls.Add(labelPages);
            Books.Controls.Add(labelInventory);
            Books.Controls.Add(labelPeriod);
            Books.Location = new Point(4, 24);
            Books.Name = "Books";
            Books.Padding = new Padding(3);
            Books.Size = new Size(218, 398);
            Books.TabIndex = 0;
            Books.Text = "Books";
            Books.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(6, 357);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(206, 35);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // checkBoxReturn
            // 
            checkBoxReturn.AutoSize = true;
            checkBoxReturn.Location = new Point(6, 254);
            checkBoxReturn.Name = "checkBoxReturn";
            checkBoxReturn.Size = new Size(105, 19);
            checkBoxReturn.TabIndex = 9;
            checkBoxReturn.Text = "Return on time";
            checkBoxReturn.UseVisualStyleBackColor = true;
            // 
            // checkBoxAvailability
            // 
            checkBoxAvailability.AutoSize = true;
            checkBoxAvailability.Location = new Point(6, 229);
            checkBoxAvailability.Name = "checkBoxAvailability";
            checkBoxAvailability.Size = new Size(137, 19);
            checkBoxAvailability.TabIndex = 8;
            checkBoxAvailability.Text = "Availability of a book";
            checkBoxAvailability.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPeriod
            // 
            numericUpDownPeriod.Location = new Point(148, 200);
            numericUpDownPeriod.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            numericUpDownPeriod.Name = "numericUpDownPeriod";
            numericUpDownPeriod.Size = new Size(45, 23);
            numericUpDownPeriod.TabIndex = 7;
            // 
            // numericUpDownInventory
            // 
            numericUpDownInventory.Location = new Point(148, 171);
            numericUpDownInventory.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownInventory.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownInventory.Name = "numericUpDownInventory";
            numericUpDownInventory.Size = new Size(45, 23);
            numericUpDownInventory.TabIndex = 6;
            numericUpDownInventory.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownPublished
            // 
            numericUpDownPublished.Location = new Point(148, 142);
            numericUpDownPublished.Maximum = new decimal(new int[] { 2050, 0, 0, 0 });
            numericUpDownPublished.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPublished.Name = "numericUpDownPublished";
            numericUpDownPublished.Size = new Size(45, 23);
            numericUpDownPublished.TabIndex = 5;
            numericUpDownPublished.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // numericUpDownPages
            // 
            numericUpDownPages.Location = new Point(148, 113);
            numericUpDownPages.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPages.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPages.Name = "numericUpDownPages";
            numericUpDownPages.Size = new Size(45, 23);
            numericUpDownPages.TabIndex = 4;
            numericUpDownPages.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBoxPublisher
            // 
            textBoxPublisher.Location = new Point(70, 84);
            textBoxPublisher.Name = "textBoxPublisher";
            textBoxPublisher.Size = new Size(123, 23);
            textBoxPublisher.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(70, 55);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(123, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(70, 26);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(123, 23);
            textBoxAuthor.TabIndex = 1;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(6, 26);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(44, 15);
            labelAuthor.TabIndex = 0;
            labelAuthor.Text = "Author";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(6, 55);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Location = new Point(6, 84);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(56, 15);
            labelPublisher.TabIndex = 0;
            labelPublisher.Text = "Publisher";
            // 
            // labelPublished
            // 
            labelPublished.AutoSize = true;
            labelPublished.Location = new Point(6, 142);
            labelPublished.Name = "labelPublished";
            labelPublished.Size = new Size(59, 15);
            labelPublished.TabIndex = 0;
            labelPublished.Text = "Published";
            // 
            // labelPages
            // 
            labelPages.AutoSize = true;
            labelPages.Location = new Point(6, 113);
            labelPages.Name = "labelPages";
            labelPages.Size = new Size(38, 15);
            labelPages.TabIndex = 0;
            labelPages.Text = "Pages";
            // 
            // labelInventory
            // 
            labelInventory.AutoSize = true;
            labelInventory.Location = new Point(6, 171);
            labelInventory.Name = "labelInventory";
            labelInventory.Size = new Size(57, 15);
            labelInventory.TabIndex = 0;
            labelInventory.Text = "Inventory";
            // 
            // labelPeriod
            // 
            labelPeriod.AutoSize = true;
            labelPeriod.Location = new Point(6, 200);
            labelPeriod.Name = "labelPeriod";
            labelPeriod.Size = new Size(41, 15);
            labelPeriod.TabIndex = 0;
            labelPeriod.Text = "Period";
            // 
            // Magazines
            // 
            Magazines.Location = new Point(4, 24);
            Magazines.Name = "Magazines";
            Magazines.Padding = new Padding(3);
            Magazines.Size = new Size(218, 398);
            Magazines.TabIndex = 1;
            Magazines.Text = "Magazines";
            Magazines.UseVisualStyleBackColor = true;
            // 
            // checkBoxSort
            // 
            checkBoxSort.AutoSize = true;
            checkBoxSort.Location = new Point(497, 402);
            checkBoxSort.Name = "checkBoxSort";
            checkBoxSort.Size = new Size(161, 19);
            checkBoxSort.TabIndex = 1;
            checkBoxSort.Text = "Sort by inventory number";
            checkBoxSort.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(240, 36);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(418, 343);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // buttonView
            // 
            buttonView.Location = new Point(244, 393);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(151, 35);
            buttonView.TabIndex = 3;
            buttonView.Text = "View";
            buttonView.UseVisualStyleBackColor = true;
            buttonView.Click += buttonView_Click;
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 450);
            Controls.Add(buttonView);
            Controls.Add(richTextBox1);
            Controls.Add(checkBoxSort);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Library";
            Text = "Library";
            tabControl1.ResumeLayout(false);
            Books.ResumeLayout(false);
            Books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPublished).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Books;
        private TabPage Magazines;
        private Label labelAuthor;
        private Label labelName;
        private Label labelPublisher;
        private Label labelPages;
        private Label labelPublished;
        private Label labelInventory;
        private Label labelPeriod;
        private TextBox textBoxAuthor;
        private TextBox textBoxPublisher;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownPeriod;
        private NumericUpDown numericUpDownInventory;
        private NumericUpDown numericUpDownPublished;
        private NumericUpDown numericUpDownPages;
        private CheckBox checkBoxAvailability;
        private Button buttonAdd;
        private CheckBox checkBoxReturn;
        private CheckBox checkBoxSort;
        private RichTextBox richTextBox1;
        private Button buttonView;
    }
}