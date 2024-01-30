using System.Xml.Schema;

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
                newLable.Location = new Point(lableForPIN.Location.X, 80);
                newLable.Size = new Size(40, 15);
                newLable.Name = "lableForPIN";
                newLable.TabIndex = 2;
                newLable.Text = "PIN2";
                groupRegDetails.Controls.Add(newLable);
                TextBox newTextBox = new TextBox();
                newTextBox.Location = new Point(textBoxForPIN.Location.X, 80);
                newTextBox.Size = new Size(textBoxForPIN.Size.Width, textBoxForPIN.Size.Height);
                newTextBox.Name = "textBoxForPIN2";
                newTextBox.TabIndex = 1;
                newTextBox.KeyPress += new KeyPressEventHandler(this.textBoxForPIN_KeyPress);
                groupRegDetails.Controls.Add(newTextBox);
                checkExtendedÑapabilities.Location = new Point(checkExtendedÑapabilities.Location.X, checkExtendedÑapabilities.Location.Y + newLimeElementHeight);
            }
            else
            {
                groupRegDetails.Size = new Size(376, groupRegDetails.Size.Height - newLimeElementHeight);
                checkExtendedÑapabilities.Location = new Point(checkExtendedÑapabilities.Location.X, checkExtendedÑapabilities.Location.Y - newLimeElementHeight);
                int count = groupRegDetails.Controls.Count;
                while (count > 4)
                {
                    groupRegDetails.Controls.RemoveAt(count - 1);
                    count--;
                }
            }
        }

        private void textBoxForName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxForName, "Must be letter");
                MessageBox.Show("The Name field cannot contain numbers");
            }
        }

        private void textBoxForPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("The PIN field cannot contain letters");
            }
        }

        private void textBoxForPIN_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxForPIN.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textBoxForPIN.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("The PIN field cannot contain letters");
                }
            }
        }
    }
}