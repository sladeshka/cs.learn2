namespace EditPerson
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
            listView1 = new ListView();
            columnName = new ColumnHeader();
            columnSurname = new ColumnHeader();
            columnAge = new ColumnHeader();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonViewList = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { columnName, columnSurname, columnAge });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(241, 363);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.VirtualMode = true;
            listView1.RetrieveVirtualItem += listView1_RetrieveVirtualItem;
            // 
            // columnName
            // 
            columnName.Text = "Name";
            // 
            // columnSurname
            // 
            columnSurname.Text = "Surname";
            // 
            // columnAge
            // 
            columnAge.Text = "Age";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 381);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(178, 381);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonViewList
            // 
            buttonViewList.Location = new Point(12, 410);
            buttonViewList.Name = "buttonViewList";
            buttonViewList.Size = new Size(241, 23);
            buttonViewList.TabIndex = 3;
            buttonViewList.Text = "View list";
            buttonViewList.UseVisualStyleBackColor = true;
            buttonViewList.Click += buttonViewList_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(12, 439);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(241, 131);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 582);
            Controls.Add(richTextBox1);
            Controls.Add(buttonViewList);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Employees";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnName;
        private ColumnHeader columnSurname;
        private ColumnHeader columnAge;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonViewList;
        private RichTextBox richTextBox1;
    }
}