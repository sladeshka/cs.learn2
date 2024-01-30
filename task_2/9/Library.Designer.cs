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
            buttonBooksAdd = new Button();
            checkBoxBooksReturn = new CheckBox();
            checkBoxBooksAvailability = new CheckBox();
            numericUpDownBooksPeriod = new NumericUpDown();
            numericUpDownBooksInventory = new NumericUpDown();
            numericUpDownBooksPublished = new NumericUpDown();
            numericUpDownBooksPages = new NumericUpDown();
            textBoxBooksPublisher = new TextBox();
            textBoxBooksTitle = new TextBox();
            textBoxBooksAuthor = new TextBox();
            labelBooksAuthor = new Label();
            labelBooksTitle = new Label();
            labelBooksPublisher = new Label();
            labelBooksPublished = new Label();
            labelBooksPages = new Label();
            labelBooksInventory = new Label();
            labelBooksPeriod = new Label();
            Magazines = new TabPage();
            buttonMagazinesAdd = new Button();
            checkBoxMagazinesSubscription = new CheckBox();
            numericUpDownMagazinesInventory = new NumericUpDown();
            numericUpDownMagazinesPublished = new NumericUpDown();
            numericUpDownMagazinesNumber = new NumericUpDown();
            textBoxMagazinesTitle = new TextBox();
            textBoxMagazinesVolume = new TextBox();
            labelMagazinesVolume = new Label();
            labelMagazinesTitle = new Label();
            labelMagazinesNumber = new Label();
            labelMagazinesPublished = new Label();
            labelMagazinesInventory = new Label();
            checkBox2Sort = new CheckBox();
            checkBoxSort = new CheckBox();
            richTextBox1 = new RichTextBox();
            buttonView = new Button();
            tabControl1.SuspendLayout();
            Books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBooksPeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBooksInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBooksPublished).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBooksPages).BeginInit();
            Magazines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMagazinesInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMagazinesPublished).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMagazinesNumber).BeginInit();
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
            Books.Controls.Add(buttonBooksAdd);
            Books.Controls.Add(checkBoxBooksReturn);
            Books.Controls.Add(checkBoxBooksAvailability);
            Books.Controls.Add(numericUpDownBooksPeriod);
            Books.Controls.Add(numericUpDownBooksInventory);
            Books.Controls.Add(numericUpDownBooksPublished);
            Books.Controls.Add(numericUpDownBooksPages);
            Books.Controls.Add(textBoxBooksPublisher);
            Books.Controls.Add(textBoxBooksTitle);
            Books.Controls.Add(textBoxBooksAuthor);
            Books.Controls.Add(labelBooksAuthor);
            Books.Controls.Add(labelBooksTitle);
            Books.Controls.Add(labelBooksPublisher);
            Books.Controls.Add(labelBooksPublished);
            Books.Controls.Add(labelBooksPages);
            Books.Controls.Add(labelBooksInventory);
            Books.Controls.Add(labelBooksPeriod);
            Books.Location = new Point(4, 24);
            Books.Name = "Books";
            Books.Padding = new Padding(3);
            Books.Size = new Size(218, 398);
            Books.TabIndex = 0;
            Books.Text = "Books";
            Books.UseVisualStyleBackColor = true;
            // 
            // buttonBooksAdd
            // 
            buttonBooksAdd.Location = new Point(6, 357);
            buttonBooksAdd.Name = "buttonBooksAdd";
            buttonBooksAdd.Size = new Size(206, 35);
            buttonBooksAdd.TabIndex = 10;
            buttonBooksAdd.Text = "Add";
            buttonBooksAdd.UseVisualStyleBackColor = true;
            buttonBooksAdd.Click += buttonAdd_Click;
            // 
            // checkBoxBooksReturn
            // 
            checkBoxBooksReturn.AutoSize = true;
            checkBoxBooksReturn.Location = new Point(6, 254);
            checkBoxBooksReturn.Name = "checkBoxBooksReturn";
            checkBoxBooksReturn.Size = new Size(105, 19);
            checkBoxBooksReturn.TabIndex = 9;
            checkBoxBooksReturn.Text = "Return on time";
            checkBoxBooksReturn.UseVisualStyleBackColor = true;
            // 
            // checkBoxBooksAvailability
            // 
            checkBoxBooksAvailability.AutoSize = true;
            checkBoxBooksAvailability.Location = new Point(6, 229);
            checkBoxBooksAvailability.Name = "checkBoxBooksAvailability";
            checkBoxBooksAvailability.Size = new Size(137, 19);
            checkBoxBooksAvailability.TabIndex = 8;
            checkBoxBooksAvailability.Text = "Availability of a book";
            checkBoxBooksAvailability.UseVisualStyleBackColor = true;
            // 
            // numericUpDownBooksPeriod
            // 
            numericUpDownBooksPeriod.Location = new Point(148, 200);
            numericUpDownBooksPeriod.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            numericUpDownBooksPeriod.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownBooksPeriod.Name = "numericUpDownBooksPeriod";
            numericUpDownBooksPeriod.Size = new Size(45, 23);
            numericUpDownBooksPeriod.TabIndex = 6;
            numericUpDownBooksPeriod.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownBooksInventory
            // 
            numericUpDownBooksInventory.Location = new Point(148, 171);
            numericUpDownBooksInventory.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownBooksInventory.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownBooksInventory.Name = "numericUpDownBooksInventory";
            numericUpDownBooksInventory.Size = new Size(45, 23);
            numericUpDownBooksInventory.TabIndex = 6;
            numericUpDownBooksInventory.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownBooksPublished
            // 
            numericUpDownBooksPublished.Location = new Point(148, 142);
            numericUpDownBooksPublished.Maximum = new decimal(new int[] { 2050, 0, 0, 0 });
            numericUpDownBooksPublished.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownBooksPublished.Name = "numericUpDownBooksPublished";
            numericUpDownBooksPublished.Size = new Size(45, 23);
            numericUpDownBooksPublished.TabIndex = 5;
            numericUpDownBooksPublished.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // numericUpDownBooksPages
            // 
            numericUpDownBooksPages.Location = new Point(148, 113);
            numericUpDownBooksPages.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownBooksPages.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownBooksPages.Name = "numericUpDownBooksPages";
            numericUpDownBooksPages.Size = new Size(45, 23);
            numericUpDownBooksPages.TabIndex = 4;
            numericUpDownBooksPages.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBoxBooksPublisher
            // 
            textBoxBooksPublisher.Location = new Point(70, 84);
            textBoxBooksPublisher.Name = "textBoxBooksPublisher";
            textBoxBooksPublisher.Size = new Size(123, 23);
            textBoxBooksPublisher.TabIndex = 3;
            // 
            // textBoxBooksTitle
            // 
            textBoxBooksTitle.Location = new Point(70, 26);
            textBoxBooksTitle.Name = "textBoxBooksTitle";
            textBoxBooksTitle.Size = new Size(123, 23);
            textBoxBooksTitle.TabIndex = 2;
            // 
            // textBoxBooksAuthor
            // 
            textBoxBooksAuthor.Location = new Point(70, 55);
            textBoxBooksAuthor.Name = "textBoxBooksAuthor";
            textBoxBooksAuthor.Size = new Size(123, 23);
            textBoxBooksAuthor.TabIndex = 1;
            // 
            // labelBooksAuthor
            // 
            labelBooksAuthor.AutoSize = true;
            labelBooksAuthor.Location = new Point(6, 55);
            labelBooksAuthor.Name = "labelBooksAuthor";
            labelBooksAuthor.Size = new Size(44, 15);
            labelBooksAuthor.TabIndex = 0;
            labelBooksAuthor.Text = "Author";
            // 
            // labelBooksTitle
            // 
            labelBooksTitle.AutoSize = true;
            labelBooksTitle.Location = new Point(6, 26);
            labelBooksTitle.Name = "labelBooksTitle";
            labelBooksTitle.Size = new Size(29, 15);
            labelBooksTitle.TabIndex = 0;
            labelBooksTitle.Text = "Title";
            // 
            // labelBooksPublisher
            // 
            labelBooksPublisher.AutoSize = true;
            labelBooksPublisher.Location = new Point(6, 84);
            labelBooksPublisher.Name = "labelBooksPublisher";
            labelBooksPublisher.Size = new Size(56, 15);
            labelBooksPublisher.TabIndex = 0;
            labelBooksPublisher.Text = "Publisher";
            // 
            // labelBooksPublished
            // 
            labelBooksPublished.AutoSize = true;
            labelBooksPublished.Location = new Point(6, 142);
            labelBooksPublished.Name = "labelBooksPublished";
            labelBooksPublished.Size = new Size(59, 15);
            labelBooksPublished.TabIndex = 0;
            labelBooksPublished.Text = "Published";
            // 
            // labelBooksPages
            // 
            labelBooksPages.AutoSize = true;
            labelBooksPages.Location = new Point(6, 113);
            labelBooksPages.Name = "labelBooksPages";
            labelBooksPages.Size = new Size(38, 15);
            labelBooksPages.TabIndex = 0;
            labelBooksPages.Text = "Pages";
            // 
            // labelBooksInventory
            // 
            labelBooksInventory.AutoSize = true;
            labelBooksInventory.Location = new Point(6, 171);
            labelBooksInventory.Name = "labelBooksInventory";
            labelBooksInventory.Size = new Size(57, 15);
            labelBooksInventory.TabIndex = 0;
            labelBooksInventory.Text = "Inventory";
            // 
            // labelBooksPeriod
            // 
            labelBooksPeriod.AutoSize = true;
            labelBooksPeriod.Location = new Point(6, 200);
            labelBooksPeriod.Name = "labelBooksPeriod";
            labelBooksPeriod.Size = new Size(41, 15);
            labelBooksPeriod.TabIndex = 0;
            labelBooksPeriod.Text = "Period";
            // 
            // Magazines
            // 
            Magazines.Controls.Add(buttonMagazinesAdd);
            Magazines.Controls.Add(checkBoxMagazinesSubscription);
            Magazines.Controls.Add(numericUpDownMagazinesInventory);
            Magazines.Controls.Add(numericUpDownMagazinesPublished);
            Magazines.Controls.Add(numericUpDownMagazinesNumber);
            Magazines.Controls.Add(textBoxMagazinesTitle);
            Magazines.Controls.Add(textBoxMagazinesVolume);
            Magazines.Controls.Add(labelMagazinesVolume);
            Magazines.Controls.Add(labelMagazinesTitle);
            Magazines.Controls.Add(labelMagazinesNumber);
            Magazines.Controls.Add(labelMagazinesPublished);
            Magazines.Controls.Add(labelMagazinesInventory);
            Magazines.Location = new Point(4, 24);
            Magazines.Name = "Magazines";
            Magazines.Padding = new Padding(3);
            Magazines.Size = new Size(218, 398);
            Magazines.TabIndex = 1;
            Magazines.Text = "Magazines";
            Magazines.UseVisualStyleBackColor = true;
            // 
            // buttonMagazinesAdd
            // 
            buttonMagazinesAdd.Location = new Point(6, 357);
            buttonMagazinesAdd.Name = "buttonMagazinesAdd";
            buttonMagazinesAdd.Size = new Size(206, 35);
            buttonMagazinesAdd.TabIndex = 10;
            buttonMagazinesAdd.Text = "Add";
            buttonMagazinesAdd.UseVisualStyleBackColor = true;
            buttonMagazinesAdd.Click += buttonMagazinesAdd_Click;
            // 
            // checkBoxMagazinesSubscription
            // 
            checkBoxMagazinesSubscription.AutoSize = true;
            checkBoxMagazinesSubscription.Location = new Point(6, 200);
            checkBoxMagazinesSubscription.Name = "checkBoxMagazinesSubscription";
            checkBoxMagazinesSubscription.Size = new Size(145, 19);
            checkBoxMagazinesSubscription.TabIndex = 8;
            checkBoxMagazinesSubscription.Text = "Magazine subscription";
            checkBoxMagazinesSubscription.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMagazinesInventory
            // 
            numericUpDownMagazinesInventory.Location = new Point(148, 171);
            numericUpDownMagazinesInventory.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownMagazinesInventory.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMagazinesInventory.Name = "numericUpDownMagazinesInventory";
            numericUpDownMagazinesInventory.Size = new Size(45, 23);
            numericUpDownMagazinesInventory.TabIndex = 6;
            numericUpDownMagazinesInventory.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownMagazinesPublished
            // 
            numericUpDownMagazinesPublished.Location = new Point(148, 142);
            numericUpDownMagazinesPublished.Maximum = new decimal(new int[] { 2050, 0, 0, 0 });
            numericUpDownMagazinesPublished.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMagazinesPublished.Name = "numericUpDownMagazinesPublished";
            numericUpDownMagazinesPublished.Size = new Size(45, 23);
            numericUpDownMagazinesPublished.TabIndex = 5;
            numericUpDownMagazinesPublished.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // numericUpDownMagazinesNumber
            // 
            numericUpDownMagazinesNumber.Location = new Point(148, 113);
            numericUpDownMagazinesNumber.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownMagazinesNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMagazinesNumber.Name = "numericUpDownMagazinesNumber";
            numericUpDownMagazinesNumber.Size = new Size(45, 23);
            numericUpDownMagazinesNumber.TabIndex = 6;
            numericUpDownMagazinesNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBoxMagazinesTitle
            // 
            textBoxMagazinesTitle.Location = new Point(70, 26);
            textBoxMagazinesTitle.Name = "textBoxMagazinesTitle";
            textBoxMagazinesTitle.Size = new Size(123, 23);
            textBoxMagazinesTitle.TabIndex = 2;
            // 
            // textBoxMagazinesVolume
            // 
            textBoxMagazinesVolume.Location = new Point(70, 55);
            textBoxMagazinesVolume.Name = "textBoxMagazinesVolume";
            textBoxMagazinesVolume.Size = new Size(123, 23);
            textBoxMagazinesVolume.TabIndex = 1;
            // 
            // labelMagazinesVolume
            // 
            labelMagazinesVolume.AutoSize = true;
            labelMagazinesVolume.Location = new Point(6, 55);
            labelMagazinesVolume.Name = "labelMagazinesVolume";
            labelMagazinesVolume.Size = new Size(47, 15);
            labelMagazinesVolume.TabIndex = 0;
            labelMagazinesVolume.Text = "Volume";
            // 
            // labelMagazinesTitle
            // 
            labelMagazinesTitle.AutoSize = true;
            labelMagazinesTitle.Location = new Point(6, 26);
            labelMagazinesTitle.Name = "labelMagazinesTitle";
            labelMagazinesTitle.Size = new Size(29, 15);
            labelMagazinesTitle.TabIndex = 0;
            labelMagazinesTitle.Text = "Title";
            // 
            // labelMagazinesNumber
            // 
            labelMagazinesNumber.AutoSize = true;
            labelMagazinesNumber.Location = new Point(6, 113);
            labelMagazinesNumber.Name = "labelMagazinesNumber";
            labelMagazinesNumber.Size = new Size(51, 15);
            labelMagazinesNumber.TabIndex = 0;
            labelMagazinesNumber.Text = "Number";
            // 
            // labelMagazinesPublished
            // 
            labelMagazinesPublished.AutoSize = true;
            labelMagazinesPublished.Location = new Point(6, 142);
            labelMagazinesPublished.Name = "labelMagazinesPublished";
            labelMagazinesPublished.Size = new Size(59, 15);
            labelMagazinesPublished.TabIndex = 0;
            labelMagazinesPublished.Text = "Published";
            // 
            // labelMagazinesInventory
            // 
            labelMagazinesInventory.AutoSize = true;
            labelMagazinesInventory.Location = new Point(6, 171);
            labelMagazinesInventory.Name = "labelMagazinesInventory";
            labelMagazinesInventory.Size = new Size(57, 15);
            labelMagazinesInventory.TabIndex = 0;
            labelMagazinesInventory.Text = "Inventory";
            // 
            // checkBox2Sort
            // 
            checkBox2Sort.Location = new Point(0, 0);
            checkBox2Sort.Name = "checkBox2Sort";
            checkBox2Sort.Size = new Size(104, 24);
            checkBox2Sort.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)numericUpDownBooksPeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBooksInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBooksPublished).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBooksPages).EndInit();
            Magazines.ResumeLayout(false);
            Magazines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMagazinesInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMagazinesPublished).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMagazinesNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Books;
        private TabPage Magazines;
        private Label labelBooksAuthor;
        private Label labelBooksTitle;
        private Label labelBooksPublisher;
        private Label labelBooksPages;
        private Label labelBooksPublished;
        private Label labelBooksInventory;
        private Label labelBooksPeriod;
        private TextBox textBoxBooksAuthor;
        private TextBox textBoxBooksPublisher;
        private TextBox textBoxBooksTitle;
        private NumericUpDown numericUpDownBooksPeriod;
        private NumericUpDown numericUpDownBooksInventory;
        private NumericUpDown numericUpDownBooksPublished;
        private NumericUpDown numericUpDownBooksPages;
        private CheckBox checkBoxBooksAvailability;
        private Button buttonBooksAdd;
        private CheckBox checkBoxBooksReturn;
        private CheckBox checkBoxSort;
        private Label labelMagazinesVolume;
        private Label labelMagazinesTitle;
        private Label labelMagazinesNumber;
        private Label labelMagazinesPublished;
        private Label labelMagazinesInventory;
        private TextBox textBoxMagazinesVolume;
        private TextBox textBoxMagazinesTitle;
        private NumericUpDown numericUpDownMagazinesInventory;
        private NumericUpDown numericUpDownMagazinesPublished;
        private NumericUpDown numericUpDownMagazinesNumber;
        private CheckBox checkBoxMagazinesSubscription;
        private Button buttonMagazinesAdd;
        private CheckBox checkBox2Sort;
        private RichTextBox richTextBox1;
        private Button buttonView;
    }
}