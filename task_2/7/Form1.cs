namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

        }

        private void checkExtendedÑapabilities_CheckedChanged(object sender, EventArgs e)
        {
            int newLimeElementHeight = 29;
            if (checkExtendedÑapabilities.Checked == true)
            {
                groupRegDetails.Size = new Size(376, groupRegDetails.Size.Height + newLimeElementHeight);
                Label newLable = new Label();
                newLable.Location = new Point(31, 80);
                newLable.Size = new Size(68, 15);
                newLable.Name = "lableForPIN";
                newLable.TabIndex = 2;
                newLable.Text = "PIN2";
                groupRegDetails.Controls.Add(newLable);
                TextBox newTextBox = new TextBox();
                newTextBox.Location = new Point(101, 80);
                newTextBox.Size = new Size(269, 23);
                newTextBox.Name = "textBoxForPIN2";
                newTextBox.TabIndex = 1;
                groupRegDetails.Controls.Add(newTextBox);
                checkExtendedÑapabilities.Location = new Point(checkExtendedÑapabilities.Location.X, checkExtendedÑapabilities.Location.Y + newLimeElementHeight);
            } else {
                groupRegDetails.Size = new Size(376, groupRegDetails.Size.Height - newLimeElementHeight);
                checkExtendedÑapabilities.Location = new Point(checkExtendedÑapabilities.Location.X, checkExtendedÑapabilities.Location.Y - newLimeElementHeight);
                int count = groupRegDetails.Controls.Count;
                while (count > 4)
                {
                    groupRegDetails.Controls.RemoveAt(count-1);
                    count--;
                }
            }
        }
    }
}